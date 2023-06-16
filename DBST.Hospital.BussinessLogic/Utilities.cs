using DBST.Hospital.DataAccess;
using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.BusinessLogic
{
    public static class Utilities
    {
        public static List<dynamic> ToDynamic(this DataTable poData)
        {
            List<object> list = new List<object>();
            foreach(DataRow dr in poData.Rows)
            {
                dynamic val = new ExpandoObject();
                list.Add(val);
                foreach(DataColumn column in poData.Columns)
                {
                    ((IDictionary<string, object>)val)[column.ColumnName] = dr[column];
                }
            }

            return list;
        }

        public static ResponseScheme GenerateResponse(bool pbIsList, DataTable poDataTable)
        {
            ResponseScheme oResponse = new ResponseScheme();

            if (!pbIsList)
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Message = "Datos obtenidos correctamente",
                    Data = Utilities.ToDynamic(poDataTable).FirstOrDefault()
                };
            }
            else
            {
                oResponse = new ResponseScheme()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Message = "Datos obtenidos correctamente",
                    Data = Utilities.ToDynamic(poDataTable).ToList()
                };

            }

            return oResponse;
        }

        public static ResponseScheme GenerateResponseWithNoData(DataTable poDataTable)
        {
            ResponseScheme oResponse = new ResponseScheme();

            dynamic data = Utilities.ToDynamic(poDataTable).FirstOrDefault();

            oResponse = new ResponseScheme()
            {
                StatusCode = (HttpStatusCode)data.StatusCode,
                Message = data.Message
            };

            return oResponse;
        }

        public static ResponseScheme CreateException(Exception poEx)
        {
            ResponseScheme oResponse = new ResponseScheme()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Message = poEx.Message
            };

            return oResponse;
        }
        public static string EncryptPassword(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for(int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
       
    }
}
