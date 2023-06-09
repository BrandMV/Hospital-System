﻿using DBST.Hospital.BussinessLogic;
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

        public static Task<ResponseScheme> GetProviderById(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsProvider>.Instance.GetProviderById(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> AddProvider(ProviderScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsProvider>.Instance.AddProvider(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> UpdateProvider(UpdateProviderScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsProvider>.Instance.UpdateProvider(poScheme);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> DeleteProvider(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsProvider>.Instance.DeleteProvider(piId);
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
