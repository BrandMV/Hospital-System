using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Office
    {
        public static Task<ResponseScheme> GetAllConsultingRooms()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsOffice>.Instance.GetAllConsultingRooms();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetOfficeById(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsOffice>.Instance.GetOfficeById(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeleteOffice(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsOffice>.Instance.DeleteOffice(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddOffice(int piLimpieza)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsOffice>.Instance.AddOffice(piLimpieza);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateOffice(OfficeScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsOffice>.Instance.UpdateOffice(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
