﻿using DBST.Hospital.DataAccess;
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
    public class clsDoctor
    {

        public DataTable GetAllDoctors()
        {
            DataTable oDataTable = new DataTable();
            try
            {
                oDataTable = ExecuteStoreProcedure("spGetAllDoctors", null);

                return oDataTable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }

        public DataTable AddDoctor(DoctorScheme poDoctor)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", poDoctor.RFC));
                loParameters.Add(new SqlParameter("@Nombre", poDoctor.Nombre));
                loParameters.Add(new SqlParameter("@SegundoNombre", poDoctor.SegundoNombre));
                loParameters.Add(new SqlParameter("@ApellidoPaterno", poDoctor.ApellidoPaterno));
                loParameters.Add(new SqlParameter("@ApellidoMaterno", poDoctor.ApellidoMaterno));
                loParameters.Add(new SqlParameter("@Salario", poDoctor.Salario));
                loParameters.Add(new SqlParameter("@Telefono", poDoctor.Telefono));
                loParameters.Add(new SqlParameter("@IdDireccion", poDoctor.IdDireccion));
                loParameters.Add(new SqlParameter("@NombreUsuario", poDoctor.NombreUsuario));
                loParameters.Add(new SqlParameter("@Contrasena", poDoctor.Contrasena));
                loParameters.Add(new SqlParameter("@Estado", poDoctor.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poDoctor.Colonia));
                loParameters.Add(new SqlParameter("@Alcaldia", poDoctor.Alcaldia));
                loParameters.Add(new SqlParameter("@Calle", poDoctor.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poDoctor.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poDoctor.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poDoctor.Cp));
                loParameters.Add(new SqlParameter("@IdConsultorio", poDoctor.IdConsultorio));

                oDataTable = ExecuteStoreProcedure("spAddDoctor", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable UpdateDoctor(DoctorScheme poDoctor)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", poDoctor.RFC));
                loParameters.Add(new SqlParameter("@Nombre", poDoctor.Nombre));
                loParameters.Add(new SqlParameter("@SegundoNombre", poDoctor.SegundoNombre));
                loParameters.Add(new SqlParameter("@ApellidoPaterno", poDoctor.ApellidoPaterno));
                loParameters.Add(new SqlParameter("@ApellidoMaterno", poDoctor.ApellidoMaterno));
                loParameters.Add(new SqlParameter("@Salario", poDoctor.Salario));
                loParameters.Add(new SqlParameter("@Telefono", poDoctor.Telefono));
                loParameters.Add(new SqlParameter("@IdDireccion", poDoctor.IdDireccion));
                loParameters.Add(new SqlParameter("@NombreUsuario", poDoctor.NombreUsuario));
                loParameters.Add(new SqlParameter("@Contrasena", poDoctor.Contrasena));
                loParameters.Add(new SqlParameter("@Estado", poDoctor.Estado));
                loParameters.Add(new SqlParameter("@Colonia", poDoctor.Colonia));
                loParameters.Add(new SqlParameter("@Alcaldia", poDoctor.Alcaldia));
                loParameters.Add(new SqlParameter("@Calle", poDoctor.Calle));
                loParameters.Add(new SqlParameter("@NoExterior", poDoctor.NoExterior));
                loParameters.Add(new SqlParameter("@NoInterior", poDoctor.NoInterior));
                loParameters.Add(new SqlParameter("@Cp", poDoctor.Cp));
                loParameters.Add(new SqlParameter("@IdConsultorio", poDoctor.IdConsultorio));

                oDataTable = ExecuteStoreProcedure("UpdateDoctor", loParameters);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DeleteDoctor(string psRFC)
        {
            DataTable oDataTable = new DataTable();
            try
            {
                List<SqlParameter> loParameters = new List<SqlParameter>();

                loParameters.Add(new SqlParameter("@RFC", psRFC));

                oDataTable = ExecuteStoreProcedure("spDeleteDoctor", loParameters);

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
