using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using SistemaAlertas.Entity;
using SistemaAlertas.Provider;
using System.Data;
using System.Data.SqlClient;
namespace SistemaAlertas.Data
{
    public class PoligonoData : PoligonoProvider
    {
        public override PoligonoEntity getEstado(string cve)
        {
            throw new NotImplementedException();
        }

        public override List<PoligonoEntity> getEstados()
        {
            string query = "select e.id as CVE, e.nombre as Nombre from EstadoPolygon e";
            PoligonoEntity entityEstado = null;
            List<PoligonoEntity> List = new List<PoligonoEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlPoligon);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstado = new PoligonoEntity();
                    entityEstado = GetEstadosFromReader(reader);
                    List.Add(entityEstado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Estados..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }

        public override PoligonoEntity getMunicipio(string cvm)
        {
            throw new NotImplementedException();
        }

        public override List<PoligonoEntity> getMunicipios(string cve)
        {
            string query = "select m.id as CVM, m.nombre as Nombre from MunicipioPolygon m where m.id_edo='"+cve+"'";
            PoligonoEntity entityMunicipio = null;
            List<PoligonoEntity> List = new List<PoligonoEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlPoligon);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityMunicipio = new PoligonoEntity();
                    entityMunicipio = GetMunicipiosFromReader(reader);
                    List.Add(entityMunicipio);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Municipios..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }

        public override List<PoligonoEntity> getPolygonMunicipios(string cvm)
        {
            PoligonoEntity entityMunicipio = null;
            List<PoligonoEntity> List = new List<PoligonoEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlPoligon);
            string query = string.Format(@"
                DECLARE @tipo AS varchar(20);
                SET @tipo = (select UPPER(m.polygon.STGeometryType()) from MunicipioPolygon m where m.id='{0}');
                SELECT geometria.STAsText() AS polygon
                FROM (
                    SELECT id, polygon.STGeometryN(n) as geometria
                    FROM MunicipioPolygon 
                    CROSS APPLY (
                            SELECT TOP (MunicipioPolygon.polygon.STNumGeometries()) ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) as n
                            FROM master..spt_values
                            ) as nums
                    WHERE MunicipioPolygon.polygon.STGeometryType() = @tipo and id='{1}') as poligonos_individuales;", cvm, cvm);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityMunicipio = new PoligonoEntity();
                    entityMunicipio = GetMunicipiosPolygonFromReader(reader);
                    List.Add(entityMunicipio);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Municipios..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }
    }
}
