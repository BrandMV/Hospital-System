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
    public class clsBinnacle
    {
        public ResponseScheme AddBinnacle(BinnacleScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsBinnacle clsBinnacle = new DataAccess.clsBinnacle();
                DataTable oDataTable = clsBinnacle.AddBinnacle(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdateBinnacle(BinnacleUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsBinnacle clsBinnacle = new DataAccess.clsBinnacle();
                DataTable oDataTable = clsBinnacle.UpdateBinnacle(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
        public ResponseScheme getUserBinnacclea(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsBinnacle clsBinnacle = new DataAccess.clsBinnacle();
                DataTable oDataTable = clsBinnacle.getUserBinnacclea(piId);

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

        public ResponseScheme getUserBinnaccleInfo(int piIdBinnacle)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsBinnacle clsBinnacle = new DataAccess.clsBinnacle();
                DataTable oDataTable = clsBinnacle.getUserBinnaccleInfo(piIdBinnacle);

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
    }
}
