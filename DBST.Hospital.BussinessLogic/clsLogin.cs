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
    public class clsLogin
    {
        public ResponseScheme Login(LoginScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsLogin clsLogin = new DataAccess.clsLogin();
                DataTable oDataTable = clsLogin.Login(poScheme);

                if(oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(false, oDataTable);
                }

            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
    }
}
