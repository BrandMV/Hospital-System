﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class WorkerScheme
    {
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public double Salario { get; set; }
        public string Telefono { get; set; }
        public int IdDireccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get;set; }

        #region Direccion
        public string Estado { get; set; }
        public string Colonia { get; set; }
        public string Alcaldia { get; set; }
        public string Calle { get; set; }
        public int NoExterior { get; set; }
        public int NoInterior { get; set; }
        public string Cp { get; set; }


        #endregion



    }
}