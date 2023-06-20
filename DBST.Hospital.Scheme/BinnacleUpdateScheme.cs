using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class BinnacleUpdateScheme
    {
        public int idRegistroBitacora { get; set; }
        public DateTime fecha { get; set; }
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
        public string padecimiento { get; set; }
        public string alergia { get; set; }
        public int idRegistroMedico { get; set; }
        public string diagnostico { get; set; }
        public DateTime fechaAsignacion { get; set; }
    }
}
