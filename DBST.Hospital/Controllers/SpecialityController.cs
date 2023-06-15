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
    public class SpecialityController : ApiController
    {
        [HttpGet]
        [Route("api/Speciality/GetAllSpecialities")]
        public async Task<ResponseScheme> GetAllSpecialities(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Speciality.GetAllSpecialities(piId);

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
        [Route("api/Speciality/GetAllSpecialitiesByDoctor")]
        public async Task<ResponseScheme> GetAllSpecialitiesByDoctor(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Speciality.GetAllSpecialitiesByDoctor(piId);

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
        [Route("api/Speciality/AddSpecialityDoctor")]
        public async Task<ResponseScheme> AddSpecialityDoctor(SpecialityDoctorScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Speciality.AddSpecialityDoctor(poScheme);

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
