using DBST.Hospital.Scheme;
using DBST.HospitalCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DBST.Hospital.Controllers
{
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
        public async Task<ResponseScheme> DeleteAppointment(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Appointment.DeleteAppointment(piId);
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
    }
}
