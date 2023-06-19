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

    public class BinnacleController : ApiController
    {
        [HttpGet]
        [Route("api/Binnacle/getUserBinnacclea")]
        public async Task<ResponseScheme> getUserBinnacclea(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Binnacle.getUserBinnacclea(piId);
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
        [Route("api/Binnacle/getUserBinnaccleInfo")]
        public async Task<ResponseScheme> getUserBinnaccleInfo(int piIdBinnacle)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Binnacle.getUserBinnaccleInfo(piIdBinnacle);
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
        [Route("api/Binnacle/AddBinnacle")]
        public async Task<ResponseScheme> AddBinnacle(BinnacleScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Binnacle.AddBinnacle(poScheme);
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
        [Route("api/Binnacle/UpdateBinnacle")]
        public async Task<ResponseScheme> UpdateBinnacle(BinnacleUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Binnacle.UpdateBinnacle(poScheme);
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
