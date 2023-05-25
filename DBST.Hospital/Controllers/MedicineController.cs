using DBST.Hospital.Scheme;
using DBST.HospitalCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DBST.Hospital.Controllers
{
    public class MedicineController : ApiController
    {
      
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Medicine/GetAllMedicine")]
        public async Task<ResponseScheme> GetAllMedicines()
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Medicine.GetAllMedicine();
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

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Medicine/AddMedicine")]
        public async Task<ResponseScheme> AddMedicine(MedicineScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Medicine.AddMedicine(poScheme);
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

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Medicine/UpdateMedicines")]
        public async Task<ResponseScheme> UpdateMedicine(MedicineUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Medicine.UpdateMedicine(poScheme);
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

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Medicine/DeleteMedicine")]
        public async Task<ResponseScheme> DeleteMedicine(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                oResponse = await Medicine.DeleteMedicine(piId);
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