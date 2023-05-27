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
    public class DoctorController : ApiController
    {

        [HttpGet]
        [Route("api/Doctor/GetAllDoctors")]
        public async Task<ResponseScheme> GetAllDoctors()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Doctor.GetAllDoctors();

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
        [Route("api/Doctor/AddDoctor")]
        public async Task<ResponseScheme> AddDoctor(DoctorScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Doctor.AddDoctor(poScheme);
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
        [Route("api/Doctor/UpdateDoctor")]
        public async Task<ResponseScheme> UpdateDoctor(DoctorUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Doctor.UpdateDoctor(poScheme);
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
        [Route("api/Doctor/DeleteDoctor")]
        public async Task<ResponseScheme> DeleteDoctor(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Doctor.DeleteDoctor(psRFC);
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
