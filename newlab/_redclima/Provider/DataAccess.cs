using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Referencias Agregadas:
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace SistemaAlertas.Provider
{
    public abstract class DataAccess
    {
        #region Conexión
        //SueloDB
        private static string sqlSuelo;
        public static string SqlSuelo
        {
            get
            {
                if (sqlSuelo == null)
                {
                    sqlSuelo = ConfigurationManager.ConnectionStrings["SueloDB"].ConnectionString;
                }
                return DataAccess.sqlSuelo;

            }
            set => sqlSuelo = value;
        }
        //PoligonoDB
        private static string sqlPoligon;
        public static string SqlPoligon 
        { 
            get {
                if (sqlPoligon == null) {
                    sqlPoligon = ConfigurationManager.ConnectionStrings["SueloDB"].ConnectionString;
                }return DataAccess.sqlPoligon;

            } 
            set => sqlPoligon = value; 
        }

        #endregion

        protected int ExecuteNonQuery(DbCommand cmd)
        {
            string systemUser = string.Empty;
            if (systemUser.Equals("Test"))
                return 1;
            else
                return cmd.ExecuteNonQuery();
        }
        protected IDataReader ExecuteReader(DbCommand cmd, CommandBehavior behavior)
        {
            return cmd.ExecuteReader(behavior);
        }
        protected Object ExecuteScalar(DbCommand cmd)
        {
            return cmd.ExecuteScalar();
        }
    }
}
