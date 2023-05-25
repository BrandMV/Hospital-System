using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Doctor
    {
        public static Task<ResponseScheme> GetAllDoctors()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsDoctor>.Instance.GetAllDoctors();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddDoctor(DoctorScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsDoctor>.Instance.AddDoctor(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateDoctor(DoctorScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsDoctor>.Instance.UpdateDoctor(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeleteDoctor(string psRFC)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsDoctor>.Instance.DeleteDoctor(psRFC);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
