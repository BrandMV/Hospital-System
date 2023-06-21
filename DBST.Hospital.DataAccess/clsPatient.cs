using DBST.Hospital.DataAccess;
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
    public class clsPatient
    {
        public DataTable GetPatients()
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                oDataTable = ExecuteStoreProcedure("spGetAllPatients", loParameters);

                return oDataTable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetPatientById(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", piId));

                oDataTable = ExecuteStoreProcedure("spGetPatientById", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetPatientsByDoctor(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@IdMedico", piId));

                oDataTable = ExecuteStoreProcedure("spGetPatientsByDoctor", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable AddPatient(PatientScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Nombre", poPatient.Nombre));
                loParameters.Add(new SqlParameter("@Paterno", poPatient.Paterno));
                loParameters.Add(new SqlParameter("@Materno", poPatient.Materno));
                loParameters.Add(new SqlParameter("@FechaNacimiento", poPatient.FechaNacimiento));
                loParameters.Add(new SqlParameter("@Email", poPatient.Email));
                loParameters.Add(new SqlParameter("@Contrasena", poPatient.Password));
                loParameters.Add(new SqlParameter("@Telefono", poPatient.Telefono));
                loParameters.Add(new SqlParameter("@Estado", poPatient.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poPatient.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poPatient.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poPatient.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poPatient.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poPatient.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poPatient.Cp));

                oDataTable = ExecuteStoreProcedure("spAddPatient", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdatePatient(UpdatePatientScheme poPatient)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", poPatient.Id));
                loParameters.Add(new SqlParameter("@IdDireccion", poPatient.IdDireccion));
                loParameters.Add(new SqlParameter("@Nombre", poPatient.Nombre));
                loParameters.Add(new SqlParameter("@Paterno", poPatient.Paterno));
                loParameters.Add(new SqlParameter("@Materno", poPatient.Materno));
                loParameters.Add(new SqlParameter("@FechaNacimiento", poPatient.FechaNacimiento));
                loParameters.Add(new SqlParameter("@Email", poPatient.Email));
                loParameters.Add(new SqlParameter("@Contrasena", poPatient.Password));
                loParameters.Add(new SqlParameter("@Telefono", poPatient.Telefono));
                loParameters.Add(new SqlParameter("@Estado", poPatient.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poPatient.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poPatient.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poPatient.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poPatient.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poPatient.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poPatient.Cp));

                oDataTable = ExecuteStoreProcedure("spUpdatePatient", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DeletePatient(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", piId));


                oDataTable = ExecuteStoreProcedure("spDeletePatient", loParameters);

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
