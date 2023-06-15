using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Admin
    {
        public static Task<ResponseScheme> GetAllAdmins()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAdmin>.Instance.GetAllAdmins();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> GetAdminByRFC(string psRFC)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAdmin>.Instance.GetAdminByRFC(psRFC);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddAdmin(AdminScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAdmin>.Instance.AddAdmin(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateAdmin(AdminUpdateScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAdmin>.Instance.UpdateAdmin(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeleteAdmin(string psRFC)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAdmin>.Instance.DeleteAdmin(psRFC);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
