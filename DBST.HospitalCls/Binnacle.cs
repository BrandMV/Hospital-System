using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Binnacle
    {
        public static Task<ResponseScheme> AddBinnacle(BinnacleScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsBinnacle>.Instance.AddBinnacle(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateBinnacle(BinnacleUpdateScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsBinnacle>.Instance.UpdateBinnacle(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> getUserBinnacclea(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsBinnacle>.Instance.getUserBinnacclea(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> getUserBinnaccleInfo(int piIdBinnacle)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsBinnacle>.Instance.getUserBinnaccleInfo(piIdBinnacle);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
