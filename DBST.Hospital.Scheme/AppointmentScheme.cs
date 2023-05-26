using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class AppointmentScheme
    {
        public string Descripcion { get; set; } 
        public DateTime Fecha { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
    }
}
