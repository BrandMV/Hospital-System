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
    public class OfficeController : ApiController
    {
        [HttpGet]
        [Route("api/Office/GetAllConsultingRooms")]
        public async Task<ResponseScheme> GetAllConsultingRooms()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Office.GetAllConsultingRooms();

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
        [Route("api/Office/GetOfficeById")]
        public async Task<ResponseScheme> GetOfficeById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Office.GetOfficeById(piId);

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
        [Route("api/Office/DeleteOffice")]
        public async Task<ResponseScheme> DeleteOffice(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Office.DeleteOffice(piId);

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
        [Route("api/Office/AddOffice")]
        public async Task<ResponseScheme> AddOffice(int piLimpieza)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Office.AddOffice(piLimpieza);
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
        [Route("api/Office/UpdateOffice")]
        public async Task<ResponseScheme> UpdateOffice(OfficeScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Office.UpdateOffice(poScheme);
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
