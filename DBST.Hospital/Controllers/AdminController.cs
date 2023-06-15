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
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("api/Admin/GetAllAdmins")]
        public async Task<ResponseScheme> GetAllAdmins()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Admin.GetAllAdmins();

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
        [Route("api/Admin/GetAdminByRFC")]
        public async Task<ResponseScheme> GetAdminByRFC(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Admin.GetAdminByRFC(psRFC);
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
        [Route("api/Admin/AddAdmin")]
        public async Task<ResponseScheme> AddAdmin(AdminScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Admin.AddAdmin(poScheme);
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
        [Route("api/Admin/UpdateAdmin")]
        public async Task<ResponseScheme> UpdateAdmin(AdminUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Admin.UpdateAdmin(poScheme);
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
        [Route("api/Admin/DeleteAdmin")]
        public async Task<ResponseScheme> DeleteAdmin(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Admin.DeleteAdmin(psRFC);
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
