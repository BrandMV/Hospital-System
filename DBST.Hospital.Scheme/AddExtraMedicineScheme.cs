using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class AddExtraMedicineScheme
    {
        public int IdMedicamento { get; set; }
        public int IdRegistroMedico { get; set; }
        public string TiempoTratamiento { get; set; }
        public string Dosificacion { get; set; }
    }
}
