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
    }
}
