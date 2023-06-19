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
    public class clsProvider
    {
        public ResponseScheme GetProviders()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsProvider clsProvider = new DataAccess.clsProvider();
                DataTable oDataTable = clsProvider.GetProviders();

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay Proveedores"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetProviderById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsProvider clsProvider = new DataAccess.clsProvider();
                DataTable oDataTable = clsProvider.GetProviderById(piId);

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

        public ResponseScheme AddProvider(ProviderScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsProvider clsProvider = new DataAccess.clsProvider();
                DataTable oDataTable = clsProvider.AddProvider(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdateProvider(UpdateProviderScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsProvider clsProvider = new DataAccess.clsProvider();
                DataTable oDataTable = clsProvider.UpdateProvider(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme DeleteProvider(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsProvider clsProvider = new DataAccess.clsProvider();
                DataTable oDataTable = clsProvider.DeleteProvider(piId);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
    }
}
