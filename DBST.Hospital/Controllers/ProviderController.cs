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
    public class ProviderController : ApiController
    {
        [HttpGet]
        [Route("api/Provider/GetProviders")]
        public async Task<ResponseScheme> GetProviders()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Provider.GetProviders();

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
