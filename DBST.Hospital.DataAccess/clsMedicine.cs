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
                List<SqlParameter> loParameters = new List<SqlParameter>();

                oDataTable = ExecuteStoreProcedure("spGetMedicines", loParameters);

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

                loParameters.Add(new SqlParameter("@IdFabricante", poMedicine.idFabricante));
                loParameters.Add(new SqlParameter("@NombreComun", poMedicine.nombreComun));
                loParameters.Add(new SqlParameter("@Docificacion", poMedicine.dosificacionRecomendada));
                loParameters.Add(new SqlParameter("@Formula", poMedicine.formaFarmaceutica));
                loParameters.Add(new SqlParameter("@Precio", poMedicine.precio));
                loParameters.Add(new SqlParameter("@Precauciones", poMedicine.precauciones));

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

        public DataTable GetMedicineById(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();
                loParameters.Add(new SqlParameter("@Id", piId));


                oDataTable = ExecuteStoreProcedure("spGetMedicineById", loParameters);

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

                loParameters.Add(new SqlParameter("@IdMedicina", poMedicine.id));
                loParameters.Add(new SqlParameter("@IdFabricante", poMedicine.idFabricante));
                loParameters.Add(new SqlParameter("@NombreComun", poMedicine.nombreComun));
                loParameters.Add(new SqlParameter("@Docificacion", poMedicine.dosificacionRecomendada));
                loParameters.Add(new SqlParameter("@Formula", poMedicine.formaFarmaceutica));
                loParameters.Add(new SqlParameter("@Precio", poMedicine.precio));
                loParameters.Add(new SqlParameter("@Precauciones", poMedicine.precauciones));

                oDataTable = ExecuteStoreProcedure("spUpdateMedicine", loParameters);
                
                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}