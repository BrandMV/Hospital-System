﻿using DBST.Hospital.BussinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.HospitalCls
{
    public class Appointment
    {
        public static Task<ResponseScheme> AddApointment(AppointmentScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.AddAppointment(poScheme);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> UpdateAppointment(UpdateAppointmentScheme poScheme)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.UpdateAppointment(poScheme);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Task<ResponseScheme> DeleteAppointment(int piId, int piIdPaciente)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.DeleteAppointment(piId, piIdPaciente);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> ValidateAppointment(int piId, DateTime fecha, int isEdit)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.ValidateAppointment(piId, fecha, isEdit);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetAppointments()
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.GetAppointments();
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetAppointmentsByPatient(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.GetAppointmentsByPatient(piId);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetAppointmentsByDoctor(string psRFC)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.GetAppointmentsByDoctor(psRFC);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetAppointmentById(int piId)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.GetAppointmentById(piId);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Task<ResponseScheme> GetAvailableHours(string psDate, string psRFC, int piIdMedico)
        {
            try
            {
                return Task.Run(() =>
                {
                    return SingletonBase<clsAppointment>.Instance.GetAvailableHours(psDate, psRFC, piIdMedico);
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
