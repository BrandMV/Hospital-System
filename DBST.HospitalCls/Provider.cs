using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Provider
    {
        public static Task<ResponseScheme> GetProviders()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsProvider>.Instance.GetProviders();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
