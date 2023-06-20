using DBST.Hospital.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.DataAccess
{
    public class clsBinnacle
    {

        public DataTable AddBinnacle(BinnacleScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();
                DataTable arrayTable = new DataTable();
                arrayTable.Columns.Add("Id", typeof(int));
                arrayTable.Columns.Add("idRegistroMedico", typeof(int));
                arrayTable.Columns.Add("tiempoTratamiento", typeof(string));
                arrayTable.Columns.Add("dosificacion", typeof(string));

                // Agregar los valores del array a la tabla
                foreach (var item in poPatient.medicamentos)
                {
                    arrayTable.Rows.Add(item.id, item.idRegistroMedico, item.tiempoTratamiento, item.dosificacion);
                }

                loParameters.Add(new SqlParameter("@Diagnostico", poPatient.diagnostico));
                loParameters.Add(new SqlParameter("@Medicinas", arrayTable));
                loParameters.Add(new SqlParameter("@IdMedico", poPatient.idMedico));
                loParameters.Add(new SqlParameter("@IdPaciente", poPatient.idPaciente));
                loParameters.Add(new SqlParameter("@Fecha", poPatient.Fecha));


                oDataTable = ExecuteStoreProcedure("spAddBinnacle", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateBinnacle(BinnacleUpdateScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@idRegBitacora", poPatient.idRegistroBitacora));
                loParameters.Add(new SqlParameter("@fecha", poPatient.fecha));
                loParameters.Add(new SqlParameter("@idPaciente", poPatient.idPaciente));
                loParameters.Add(new SqlParameter("@idMedico", poPatient.idMedico));
                loParameters.Add(new SqlParameter("@idRegMedico", poPatient.idRegistroMedico));
                loParameters.Add(new SqlParameter("@diagnostico", poPatient.diagnostico));
                loParameters.Add(new SqlParameter("@fechaAsignacion", poPatient.fechaAsignacion));


                oDataTable = ExecuteStoreProcedure("spUpdateBinnacle", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable getUserBinnacclea(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdPaciente", piId));

                oDataTable = ExecuteStoreProcedure("spUserLogs", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getUserBinnaccleInfo(int piIdBinnacle)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdBitacora", piIdBinnacle));

                oDataTable = ExecuteStoreProcedure("spGetLogInfo", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
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
    }
}
