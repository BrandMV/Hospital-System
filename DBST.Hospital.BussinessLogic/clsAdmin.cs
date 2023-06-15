using DBST.Hospital.BusinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.BussinessLogic
{
    public class clsAdmin
    {
        public ResponseScheme GetAllAdmins()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsAdmin clsAdmin = new DataAccess.clsAdmin();
                DataTable oDataTable = clsAdmin.GetAllAdmins();

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }


        public ResponseScheme GetAdminByRFC(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsAdmin clsAdmin = new DataAccess.clsAdmin();
                DataTable oDataTable = clsAdmin.GetAdminByRFC(psRFC);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme AddAdmin(AdminScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsAdmin clsAdmin = new DataAccess.clsAdmin();
                DataTable oDataTable = clsAdmin.AddAdmin(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdateAdmin(AdminUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsAdmin clsAdmin = new DataAccess.clsAdmin();
                DataTable oDataTable = clsAdmin.UpdateAdmin(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
        public ResponseScheme DeleteAdmin(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsAdmin clsAdmin = new DataAccess.clsAdmin();
                DataTable oDataTable = clsAdmin.DeleteAdmin(psRFC);

                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Message = "El administrador se elimino correctamente"
                };
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
    }
}
