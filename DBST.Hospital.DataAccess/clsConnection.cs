using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.DataAccess
{
    public static class clsConnection
    {

        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder lsConnectionString = new SqlConnectionStringBuilder();
            lsConnectionString.DataSource = @".\SQLExpress";
            lsConnectionString.InitialCatalog = "Hospital";
            lsConnectionString.IntegratedSecurity = true;

            return lsConnectionString.ConnectionString;
        }
        public static DataTable ExecuteStoreProcedure(string psStoredProcedure, SqlParameter[] poSqlParameter)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                //using(SqlConnection conn = new SqlConnection("data source=.;initial catalog=Hospital;integrated security=true;"))
                using(SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(psStoredProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(poSqlParameter);

                        oDataTable.Load(cmd.ExecuteReader());
                    }
                    conn.Close();
                }

                return oDataTable;
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
        }
    }
}
