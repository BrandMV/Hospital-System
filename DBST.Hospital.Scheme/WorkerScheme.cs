using System;
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
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public double Salario { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        //public int IdDireccion { get; set; }
        public string Email { get; set; }
        public string horario { get; set; }

        #region Direccion
        public string Estado { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Calle { get; set; }
        public int NoExterior { get; set; }
        public int NoInterior { get; set; }
        public string Cp { get; set; }


        #endregion



    }
}
