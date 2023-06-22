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
    public class clsReceipts
    {
        public DataTable GetReceiptsByUser(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@Id", piId));
                dt = ExecuteStoreProcedure("GetReceiptsByUser", loParams);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetUserReceipts(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@Id", piId));
                dt = ExecuteStoreProcedure("spGetUserReceipts", loParams);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetRecetaInfo(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@Id", piId));
                dt = ExecuteStoreProcedure("spGetRecetaInfo", loParams);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable AddExtraMedicine(AddExtraMedicineScheme poScheme)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();
                loParams.Add(new SqlParameter("@IdMedicamento", poScheme.IdMedicamento));
                loParams.Add(new SqlParameter("@IdRegistroMedico", poScheme.IdRegistroMedico));
                loParams.Add(new SqlParameter("@TiempoTratamiento", poScheme.TiempoTratamiento));
                loParams.Add(new SqlParameter("@Dosificacion", poScheme.Dosificacion));
                dt = ExecuteStoreProcedure("spAddExtraMedicine", loParams);

                return dt;
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
