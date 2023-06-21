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
    public class clsPatient
    {
        public ResponseScheme GetAllPatients()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.GetPatients();

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

        public ResponseScheme GetPatientById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.GetPatientById(piId);

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
        public ResponseScheme GetPatientsByDoctor(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.GetPatientsByDoctor(piId);

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

        public ResponseScheme AddPatient(PatientScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                poScheme.Password = Utilities.EncryptPassword(poScheme.Password);
                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.AddPatient(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdatePatient(UpdatePatientScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.UpdatePatient(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme DeletePatient(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsPatient clsPatient = new DataAccess.clsPatient();
                DataTable oDataTable = clsPatient.DeletePatient(piId);

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
