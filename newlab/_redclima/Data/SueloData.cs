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
    public class SueloData : SueloProvider
    {
        public override List<SueloEntity> getSueloDataByMun(string cve,string cvm, List<string> profundidades)
        {
            string list_prof = "";
            foreach (string prof in profundidades) {
                list_prof += ",sl." + prof;
            }
            string query = string.Format(@" DECLARE @NUM_MUN varchar(15)='{0}'
            DECLARE @polygon geometry = geometry::STGeomFromText(
            ( select polygon.ToString() from MunicipioPolygon where id=@NUM_MUN),4326)
            select 
            sl.punto_geometry.STY as latitud,sl.punto_geometry.STX as longitud {1} 
            from Suelos.dbo.EST_{2} sl where  sl.punto_geometry.STWithin(@polygon)=1
            ",cvm,list_prof,cve);
            SueloEntity entityEstado = null;
            List<SueloEntity> List = new List<SueloEntity>();

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
                    entityEstado = new SueloEntity();
                    entityEstado = GetSueloDataFromReader(reader,profundidades);
                    List.Add(entityEstado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Suelo..." + ex.Message, ex);
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
