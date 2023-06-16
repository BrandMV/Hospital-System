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
    public class clsDoctor
    {
        public ResponseScheme GetAllDoctors()
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsDoctor clsDoctor = new DataAccess.clsDoctor();
                DataTable oDataTable = clsDoctor.GetAllDoctors();

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


        public ResponseScheme GetDoctorById(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {
                DBST.Hospital.DataAccess.clsDoctor clsDoctor = new DataAccess.clsDoctor();
                DataTable oDataTable = clsDoctor.GetDoctorById(piId);

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

        public ResponseScheme AddDoctor(DoctorScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                poScheme.Password = Utilities.EncryptPassword(poScheme.Password);
                DBST.Hospital.DataAccess.clsDoctor clsDoctor = new DataAccess.clsDoctor();
                DataTable oDataTable = clsDoctor.AddDoctor(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme UpdateDoctor(DoctorUpdateScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsDoctor clsDoctor = new DataAccess.clsDoctor();
                DataTable oDataTable = clsDoctor.UpdateDoctor(poScheme);

                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
        public ResponseScheme DeleteDoctor(string psRFC)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsDoctor clsDoctor = new DataAccess.clsDoctor();
                DataTable oDataTable = clsDoctor.DeleteDoctor(psRFC);

                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Message = "El Doctor se elimino correctamente"
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
