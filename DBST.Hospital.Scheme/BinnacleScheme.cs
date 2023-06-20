using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class BinnacleScheme
    {
        public string diagnostico { get; set; }
        public List<MedicamentoLogScheme> medicamentos { get; set; }
        public int idMedico { get; set; }
        public int idPaciente { get; set; }
        public DateTime Fecha { get; set; }
    }

}
