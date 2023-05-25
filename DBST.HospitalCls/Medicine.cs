
using DBST.Hospital.BusinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Medicine
    {
        public static Task<ResponseScheme> GetAllMedicine()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsMedicine>.Instance.GetAllMedicines();
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddMedicine(MedicineScheme poMedicine)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsMedicine>.Instance.AddMedicine(poMedicine);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateMedicine(MedicineUpdateScheme poMedicine)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsMedicine>.Instance.UpdateMedicine(poMedicine);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeleteMedicine(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsMedicine>.Instance.DeleteMedicine(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
