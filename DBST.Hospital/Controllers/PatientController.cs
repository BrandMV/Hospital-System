using DBST.Hospital.BussinessLogic;
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

    public class PatientController : ApiController
    {
        [HttpGet]
        [Route("api/Patient/GetAllPatients")]
        public async Task<ResponseScheme> GetAllPatients()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Patient.GetAllPatients();

            }
            catch(Exception ex)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return oResponse;
        }

        [HttpPost]
        [Route("api/Patient/AddPatient")]
        public async Task<ResponseScheme> AddPatient(PatientScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Patient.AddPatient(poScheme);
            }
            catch (Exception ex)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return oResponse;
        }

        [HttpPost]
        [Route("api/Patient/UpdatePatient")]
        public async Task<ResponseScheme> UpdatePatient(UpdatePatientScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Patient.UpdatePatient(poScheme);
            }
            catch (Exception ex)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return oResponse;
        }


        [HttpPost]
        [Route("api/Patient/DeletePatient")]
        public async Task<ResponseScheme> DeletePatient(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Patient.DeletePatient(piId);
            }
            catch (Exception ex)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return oResponse;
        }

        [HttpGet]
        [Route("api/Patient/GetPatientById")]
        public async Task<ResponseScheme> GetPatientById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Patient.GetPatientById(piId);
            }
            catch (Exception ex)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                };
            }
            return oResponse;
        }
    }
}
