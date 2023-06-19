using DBST.Hospital.Scheme;
using System;
using System.Data;

namespace DBST.Hospital.BusinessLogic
{
    public class clsMedicine
    {
        public ResponseScheme GetAllMedicines()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsMedicine clsMedicine = new DataAccess.clsMedicine();
                DataTable oDataTable = clsMedicine.GetAllMedicine();

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

       

        public ResponseScheme AddMedicine(MedicineScheme poMedicine)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsMedicine clsMedicine = new DataAccess.clsMedicine();
                DataTable oDataTable = clsMedicine.AddMedicine(poMedicine);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch(Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }


            return oResponse;
        }

        public ResponseScheme DeleteMedicine(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsMedicine clsMedicine = new DataAccess.clsMedicine();
                DataTable oDataTable = clsMedicine.DeleteMedicine(piId);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetMedicineById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsMedicine clsMedicine = new DataAccess.clsMedicine();
                DataTable oDataTable = clsMedicine.GetMedicineById(piId);

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

        public ResponseScheme UpdateMedicine(MedicineUpdateScheme poMedicine)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DataAccess.clsMedicine clsMedicine = new DataAccess.clsMedicine();
                DataTable oDataTable = clsMedicine.UpdateMedicine(poMedicine);

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