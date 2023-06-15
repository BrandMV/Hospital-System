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
    }
}
