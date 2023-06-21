using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Receipt
    {
        public static Task<ResponseScheme> GetReceiptsByUser(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsReceipts>.Instance.GetReceiptsByUser(piId);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
