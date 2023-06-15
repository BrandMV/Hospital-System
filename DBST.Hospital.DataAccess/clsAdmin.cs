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
    public class clsAdmin
    {
        public DataTable GetAllAdmins()
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                oDataTable = ExecuteStoreProcedure("spGetAllAdmins", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAdminByRFC(string psRFC)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", psRFC));

                oDataTable = ExecuteStoreProcedure("spGetAdminByRFC", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable AddAdmin(AdminScheme poAdmin)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", poAdmin.RFC));
                loParameters.Add(new SqlParameter("@Nombre", poAdmin.Nombre));
                loParameters.Add(new SqlParameter("@SegundoNombre", poAdmin.SegundoNombre));
                loParameters.Add(new SqlParameter("@Paterno", poAdmin.Paterno));
                loParameters.Add(new SqlParameter("@Materno", poAdmin.Materno));
                loParameters.Add(new SqlParameter("@Salario", poAdmin.Salario));
                loParameters.Add(new SqlParameter("@Telefono", poAdmin.Telefono));
                loParameters.Add(new SqlParameter("@Email", poAdmin.Email));
                loParameters.Add(new SqlParameter("@Contrasena", poAdmin.Password));
                loParameters.Add(new SqlParameter("@FechaNacimiento", poAdmin.FechaNacimiento));
                loParameters.Add(new SqlParameter("@Estado", poAdmin.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poAdmin.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poAdmin.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poAdmin.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poAdmin.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poAdmin.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poAdmin.Cp));
                loParameters.Add(new SqlParameter("@Titulacion", poAdmin.Titulacion));
                loParameters.Add(new SqlParameter("@Horario", poAdmin.horario));

                oDataTable = ExecuteStoreProcedure("spAddAdmin", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateAdmin(AdminUpdateScheme poAdmin)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", poAdmin.RFC));
                loParameters.Add(new SqlParameter("@Nombre", poAdmin.Nombre));
                loParameters.Add(new SqlParameter("@SegundoNombre", poAdmin.SegundoNombre));
                loParameters.Add(new SqlParameter("@Paterno", poAdmin.Paterno));
                loParameters.Add(new SqlParameter("@Materno", poAdmin.Materno));
                loParameters.Add(new SqlParameter("@Salario", poAdmin.Salario));
                loParameters.Add(new SqlParameter("@Telefono", poAdmin.Telefono));
                loParameters.Add(new SqlParameter("@IdDireccion", poAdmin.IdDireccion));
                loParameters.Add(new SqlParameter("@Email", poAdmin.Email));
                loParameters.Add(new SqlParameter("@Contrasena", poAdmin.Password));
                loParameters.Add(new SqlParameter("@FechaNacimiento", poAdmin.FechaNacimiento));
                loParameters.Add(new SqlParameter("@Estado", poAdmin.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poAdmin.Colonia));
                loParameters.Add(new SqlParameter("@Municipio", poAdmin.Municipio));
                loParameters.Add(new SqlParameter("@Calle", poAdmin.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poAdmin.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poAdmin.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poAdmin.Cp));
                loParameters.Add(new SqlParameter("@Titulacion", poAdmin.Titulacion));

                oDataTable = ExecuteStoreProcedure("spUpdateAdmin", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DeleteAdmin(string psRFC)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", psRFC));

                oDataTable = ExecuteStoreProcedure("spDeleteAdmin", loParameters);

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
