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
                List<SqlParameter> loParameters = new List<SqlParameter>();

                dt = ExecuteStoreProcedure("spGetAppointments", loParameters);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GetAppointmentsByPatient(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@IdPatient", piId));
                dt = ExecuteStoreProcedure("spGetAppointmentsByPatient", loParams);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAppointmentById(int piId)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@Id", piId));
                dt = ExecuteStoreProcedure("spGetAppointmenById", loParams);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAppointmentsByDoctor(string psRFC)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@RFC", psRFC));
                dt = ExecuteStoreProcedure("spGetAppointmentsByDoctor", loParams);
                return dt;
            }
            catch (Exception ex)
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

        public DataTable DeleteAppointment(int piId, int piIdPaciente)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@IdCita", piId));
                loParams.Add(new SqlParameter("@IdPaciente", piIdPaciente));

                dt = ExecuteStoreProcedure("spDeleteAppointment", loParams);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ValidateAppointment(int piId, DateTime fecha, int isEdit)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();

                loParams.Add(new SqlParameter("@IdPaciente", piId));
                loParams.Add(new SqlParameter("@FechaCita", fecha));
                loParams.Add(new SqlParameter("@IsEdit", isEdit));

                dt = ExecuteStoreProcedure("spValidateUserAppointment", loParams);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAvailableHours(string psDate, string psRFC, int piIdMedico)
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParams = new List<SqlParameter>();
                loParams.Add(new SqlParameter("@Fecha", psDate));
                loParams.Add(new SqlParameter("@RFC", psRFC));
                loParams.Add(new SqlParameter("@IdMedico", piIdMedico));

                dt = ExecuteStoreProcedure("spGetAvailableHours", loParams);

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
