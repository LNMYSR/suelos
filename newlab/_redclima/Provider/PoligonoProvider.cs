using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Runtime.Remoting;
using System.Configuration;
using SistemaAlertas.Entity;
using System.Data;
namespace SistemaAlertas.Provider
{
    public abstract class PoligonoProvider:DataAccess
    {
        private static ObjectHandle obj; //manejador de objeto.
        private static PoligonoProvider _Intance = null;

        public static PoligonoProvider Intance 
        { 
            get {
                if (_Intance == null) {
                    obj = Activator.CreateInstance(
                        ConfigurationManager.AppSettings["PoligonoDLL"],
                        ConfigurationManager.AppSettings["PoligonoClass"]);
                    _Intance = (PoligonoProvider)obj.Unwrap();
                }
                return _Intance;
            } 
            set => _Intance = value; 
        }
        public PoligonoProvider() { }
        public abstract List<PoligonoEntity> getEstados();
        public abstract List<PoligonoEntity> getMunicipios(string cve);
        public abstract List<PoligonoEntity> getPolygonMunicipios(string cvm);
        public abstract PoligonoEntity getEstado(string cve);
        public abstract PoligonoEntity getMunicipio(string cvm);
        public virtual PoligonoEntity GetEstadosFromReader(IDataReader reader) {
            PoligonoEntity entity = null;
            try
            {
                entity = new PoligonoEntity();
                entity.CVE= reader["CVE"] == System.DBNull.Value ? "NULL" : (string)reader["CVE"];
                entity.Nombre = reader["Nombre"] == System.DBNull.Value ? "NULL" : (string)reader["Nombre"];
            }
            catch (Exception ex) {
                throw new Exception("Error...", ex);
            }
            return entity;
        }
        public virtual PoligonoEntity GetMunicipiosFromReader(IDataReader reader)
        {
            PoligonoEntity entity = null;
            try
            {
                entity = new PoligonoEntity();
                entity.CVM = reader["CVM"] == System.DBNull.Value ? "NULL" : (string)reader["CVM"];
                entity.Nombre = reader["Nombre"] == System.DBNull.Value ? "NULL" : (string)reader["Nombre"];
            }
            catch (Exception ex)
            {
                throw new Exception("Error...", ex);
            }
            return entity;
        }
        public virtual PoligonoEntity GetMunicipiosPolygonFromReader(IDataReader reader)
        {
            PoligonoEntity entity = null;
            try
            {
                entity = new PoligonoEntity();
                entity.Poligono = reader["polygon"] == System.DBNull.Value ? "NULL" : (string)reader["polygon"];
            }
            catch (Exception ex)
            {
                throw new Exception("Error...", ex);
            }
            return entity;
        }
    }
}
