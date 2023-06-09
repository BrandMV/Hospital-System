﻿using DBST.Hospital.BusinessLogic;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.BussinessLogic
{
    public class clsReceipts
    {
        public ResponseScheme GetReceiptsByUser(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsReceipts clsReceipts = new DataAccess.clsReceipts();
                DataTable oDataTable = clsReceipts.GetReceiptsByUser(piId);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay citas"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetUserReceipts(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsReceipts clsReceipts = new DataAccess.clsReceipts();
                DataTable oDataTable = clsReceipts.GetUserReceipts(piId);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay recetas"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme AddExtraMedicine(AddExtraMedicineScheme poScheme)
        {
            ResponseScheme oResponse = new ResponseScheme();
            try
            {
                DBST.Hospital.DataAccess.clsReceipts clsReceipts = new DataAccess.clsReceipts();
                DataTable oDataTable = clsReceipts.AddExtraMedicine(poScheme);
                oResponse = Utilities.GenerateResponseWithNoData(oDataTable);
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }

        public ResponseScheme GetRecetaInfo(int piId)
        {
            ResponseScheme oResponse = new ResponseScheme();

            try
            {

                DBST.Hospital.DataAccess.clsReceipts clsReceipts = new DataAccess.clsReceipts();
                DataTable oDataTable = clsReceipts.GetRecetaInfo(piId);

                if (oDataTable.Rows.Count > 0)
                {
                    oResponse = Utilities.GenerateResponse(true, oDataTable);
                }
                else
                {
                    oResponse = new ResponseScheme()
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "No hay recetas"
                    };
                }
            }
            catch (Exception ex)
            {
                oResponse = Utilities.CreateException(ex);
            }

            return oResponse;
        }
    }
}
