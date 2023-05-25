using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DBST.Hospital.DataAccess
{
    public class clsMedicine
    {
        public DataTable GetAllMedicine()
        {
            DataTable oDataTable = new DataTable();
            try
            {
                oDataTable = ExecuteStoreProcedure("spGetMedicines", null);

                return oDataTable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecuteStoreProcedure(string psStoredProcedure, List<SqlParameter> poParameters)
        {
            DataTable oDataTable = new DataTable();

            oDataTable = clsConnection.ExecuteStoreProcedure(psStoredProcedure, poParameters.ToArray());

            return oDataTable;
        }

        public DataTable AddMedicine(MedicineScheme poMedicine)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdFabricante", poMedicine.IdFabricante));
                loParameters.Add(new SqlParameter("@NombreComun", poMedicine.NombreComun));
                loParameters.Add(new SqlParameter("@Decificacion", poMedicine.DocificacionRecomendada));
                loParameters.Add(new SqlParameter("@Formula", poMedicine.Formula));
                loParameters.Add(new SqlParameter("@Precio", poMedicine.Precio));
                loParameters.Add(new SqlParameter("@Precausiones", poMedicine.Precauciones));
                loParameters.Add(new SqlParameter("@Stock", poMedicine.Stock));

                oDataTable = ExecuteStoreProcedure("spAddMedicine", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DeleteMedicine(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", piId));
               

                oDataTable = ExecuteStoreProcedure("spDeleteMedicine", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateMedicine(MedicineUpdateScheme poMedicine)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdFabricante", poMedicine.IdFabricante));
                loParameters.Add(new SqlParameter("@NombreComun", poMedicine.NombreComun));
                loParameters.Add(new SqlParameter("@Decificacion", poMedicine.DocificacionRecomendada));
                loParameters.Add(new SqlParameter("@Formula", poMedicine.Formula));
                loParameters.Add(new SqlParameter("@Precio", poMedicine.Precio));
                loParameters.Add(new SqlParameter("@Precausiones", poMedicine.Precauciones));
                loParameters.Add(new SqlParameter("@Stock", poMedicine.Stock));

                oDataTable = ExecuteStoreProcedure("spAddMedicine", loParameters);
                
                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}