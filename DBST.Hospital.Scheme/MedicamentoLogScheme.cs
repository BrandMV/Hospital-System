using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class MedicamentoLogScheme
    {
        public string dosificacion { get; set; }
        public int id{ get; set; }
        public string nombre { get; set; }
        public string tiempoTratamiento { get; set; }
        public int idRegistroMedico { get; set; }
    }
}
