using DBST.Hospital.BusinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.BussinessLogic
{
    public class clsAppointment
    {
        public ResponseScheme GetAppointments()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.GetAppointments();

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay citas"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetAvailableHours(string psDate, string psRFC, int piIdMedico)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.GetAvailableHours(psDate, psRFC, piIdMedico);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay horas disponibles para esta fecha"
                    };
                }

            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
        
        public ResponseScheme GetAppointmentsByPatient(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.GetAppointmentsByPatient(piId);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay citas"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetAppointmentById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.GetAppointmentById(piId);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme ValidateAppointment(int piId, DateTime fecha, int isEdit)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.ValidateAppointment(piId, fecha, isEdit);
                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme AddAppointment(AppointmentScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.AddAppointment(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdateAppointment(UpdateAppointmentScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.UpdateAppointment(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme DeleteAppointment(int piId, int piIdPaciente)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsAppointment clsAppointment = new DataAccess.clsAppointment();
                DataTable oDataTable = clsAppointment.DeleteAppointment(piId, piIdPaciente);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);


            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
    }
}
