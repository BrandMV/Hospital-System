using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Speciality
    {
        public static Task<ResponseScheme> GetAllSpecialities(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsSpeciality>.Instance.GetAllSpecialities(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> GetAllSpecialitiesByDoctor(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsSpeciality>.Instance.GetAllSpecialitiesByDoctor(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddSpecialityDoctor(SpecialityDoctorScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsSpeciality>.Instance.AddSpecialityDoctor(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
