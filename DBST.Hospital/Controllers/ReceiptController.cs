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

    public class ReceiptController : ApiController
    {
        [HttpGet]
        [Route("api/Receipt/GetReceiptsByUser")]
        public async Task<ResponseScheme> GetReceiptsByUser(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Receipt.GetReceiptsByUser(piId);
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
        [Route("api/Receipt/GetUserReceipts")]
        public async Task<ResponseScheme> GetUserReceipts(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Receipt.GetUserReceipts(piId);
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
        [Route("api/Receipt/AddExtraMedicine")]
        public async Task<ResponseScheme> AddExtraMedicine(AddExtraMedicineScheme poScheme)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Receipt.AddExtraMedicine(poScheme);
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
        [Route("api/Receipt/GetRecetaInfo")]
        public async Task<ResponseScheme> GetRecetaInfo(int piId)
        {
            ResponseScheme loResponse = new ResponseScheme();
            try
            {
                loResponse = await Receipt.GetRecetaInfo(piId);
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
