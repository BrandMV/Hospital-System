using DBST.Hospital.Scheme;
using DBST.HospitalCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DBST.Hospital.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class AppointmentController : ApiController
    {
        [HttpPost]
        [Route("api/Appointment/AddAppointment")]
        public async Task<ResponseScheme> AddAppointment(AppointmentScheme poScheme)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.AddApointment(poScheme);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpPost]
        [Route("api/Appointment/UpdateAppointment")]
        public async Task<ResponseScheme> UpdateAppointment(UpdateAppointmentScheme poScheme)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.UpdateAppointment(poScheme);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpPost]
        [Route("api/Appointment/DeleteAppointment")]
        public async Task<ResponseScheme> DeleteAppointment(int piId, int piIdPaciente)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.DeleteAppointment(piId, piIdPaciente);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/ValidateAppointment")]
        public async Task<ResponseScheme> ValidateAppointment(int piId, DateTime fecha, int isEdit)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.ValidateAppointment(piId, fecha, isEdit);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/GetAvailableHours")]

        public async Task<ResponseScheme> GetAvailableHours(string psDate, string psRFC, int piIdMedico)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.GetAvailableHours(psDate, psRFC, piIdMedico);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/GetAppointments")]
        public async Task<ResponseScheme> GetAppointments()
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.GetAppointments();
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/GetAppointmentsByPatient")]
        public async Task<ResponseScheme> GetAppointmentsByPatient(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.GetAppointmentsByPatient(piId);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/GetAppointmentsByDoctor")]
        public async Task<ResponseScheme> GetAppointmentsByDoctor(string psRFC)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.GetAppointmentsByDoctor(psRFC);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }

        [HttpGet]
        [Route("api/Appointment/GetAppointmentById")]
        public async Task<ResponseScheme> GetAppointmentById(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.GetAppointmentById(piId);
            }
            catch (Exception ex)
            {
                loResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return loResponse;
        }
    }
}
