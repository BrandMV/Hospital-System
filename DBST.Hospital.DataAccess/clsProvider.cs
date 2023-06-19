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
    public class clsProvider
    {
        public DataTable GetProviders()
        {
            DataTable dt = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                dt = ExecuteStoreProcedure("spGetProviders", loParameters);
                return dt;
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

        public DataTable GetProviderById(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();
                loParameters.Add(new SqlParameter("@Id", piId));


                oDataTable = ExecuteStoreProcedure("spGetProviderById", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable AddProvider(ProviderScheme poProvider)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@infoRegistro", poProvider.infoRegistro));
                loParameters.Add(new SqlParameter("@infoLicencia", poProvider.infoLicencia));
                loParameters.Add(new SqlParameter("@telefono", poProvider.telefono));
                loParameters.Add(new SqlParameter("@nombre", poProvider.nombre));
                loParameters.Add(new SqlParameter("@sitioWeb", poProvider.sitioWeb));
                loParameters.Add(new SqlParameter("@email", poProvider.email));
                loParameters.Add(new SqlParameter("@Estado", poProvider.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poProvider.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poProvider.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poProvider.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poProvider.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poProvider.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poProvider.Cp));

                oDataTable = ExecuteStoreProcedure("spAddProvider", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateProvider(UpdateProviderScheme poProvider)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", poProvider.Id));
                loParameters.Add(new SqlParameter("@infoRegistro", poProvider.infoRegistro));
                loParameters.Add(new SqlParameter("@infoLicencia", poProvider.infoLicencia));
                loParameters.Add(new SqlParameter("@telefono", poProvider.telefono));
                loParameters.Add(new SqlParameter("@nombre", poProvider.nombre));
                loParameters.Add(new SqlParameter("@sitioWeb", poProvider.sitioWeb));
                loParameters.Add(new SqlParameter("@email", poProvider.email));
                loParameters.Add(new SqlParameter("@IdDireccion", poProvider.IdDireccion));
                loParameters.Add(new SqlParameter("@Estado", poProvider.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poProvider.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poProvider.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poProvider.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poProvider.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poProvider.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poProvider.Cp));

                oDataTable = ExecuteStoreProcedure("spUpdateProvider", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable DeleteProvider(int piId)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@Id", piId));


                oDataTable = ExecuteStoreProcedure("spDeleteProvider", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
