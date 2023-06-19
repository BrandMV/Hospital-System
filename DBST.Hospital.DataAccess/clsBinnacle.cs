using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.DataAccess
{
    public class clsBinnacle
    {

        public DataTable AddBinnacle(BinnacleScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                //loParameters.Add(new SqlParameter("@Nombre", poPatient.Nombre));
          

                oDataTable = ExecuteStoreProcedure("spAddBinnacle", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateBinnacle(BinnacleUpdateScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                //loParameters.Add(new SqlParameter("@Nombre", poPatient.Nombre));


                oDataTable = ExecuteStoreProcedure("spUpdateBinnacle", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable getUserBinnacclea(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdPaciente", piId));

                oDataTable = ExecuteStoreProcedure("spUserLogs", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getUserBinnaccleInfo(int piIdBinnacle)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdPaciente", piIdBinnacle));

                oDataTable = ExecuteStoreProcedure("spGetLogInfo", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecuteStoreProcedure(string psStoredProcedure, List<SqlParameter> poParameters)
        {
            DataTable oDataTable = new DataTable();

            oDataTable = clsConnection.ExecuteStoreProcedure(psStoredProcedure, poParameters.ToArray());

            return oDataTable;
        }
    }
}
