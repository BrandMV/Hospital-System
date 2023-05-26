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
    public class clsAppointment
    {
        
        public DataTable GetAppointments()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ExecuteStoreProcedure("spGetAppointments", null);
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable AddAppointment(AppointmentScheme poScheme)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@Descripcion", poScheme.Descripcion));
                loParams.Add(new SqlParameter("@Fecha", poScheme.Fecha));
                loParams.Add(new SqlParameter("@IdMedico", poScheme.IdMedico));
                loParams.Add(new SqlParameter("@IdPaciente", poScheme.IdPaciente));

                dt = ExecuteStoreProcedure("spAddAppointment", loParams);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateAppointment(UpdateAppointmentScheme poScheme)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@IdCita", poScheme.IdCita));
                loParams.Add(new SqlParameter("@Descripcion", poScheme.Descripcion));
                loParams.Add(new SqlParameter("@Fecha", poScheme.Fecha));
                loParams.Add(new SqlParameter("@IdMedico", poScheme.IdMedico));
                loParams.Add(new SqlParameter("@IdPaciente", poScheme.IdPaciente));

                dt = ExecuteStoreProcedure("spUpdateAppointment", loParams);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DeleteAppointment(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@IdCita", piId));
                
                dt = ExecuteStoreProcedure("spDeleteAppointment", loParams);

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
