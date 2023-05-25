using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Patient
    {
        public static Task<ResponseScheme> GetAllPatients()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsPatient>.Instance.GetAllPatients();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> AddPatient(PatientScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsPatient>.Instance.AddPatient(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdatePatient(UpdatePatientScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsPatient>.Instance.UpdatePatient(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeletePatient(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsPatient>.Instance.DeletePatient(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

