using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class UpdateProviderScheme
    {
        public string nombre { get; set; }
        public string infoRegistro { get; set; }
        public string infoLicencia { get; set; }
        public string telefono { get; set; }
        public string sitioWeb { get; set; }
        public string email { get; set; }
        #region Direccion
        public string Estado { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Calle { get; set; }
        public int NoExterior { get; set; }
        public int NoInterior { get; set; }
        public string Cp { get; set; }
        public int Id { get; set; }
        public int IdDireccion { get; set; }
        #endregion
    }
}
