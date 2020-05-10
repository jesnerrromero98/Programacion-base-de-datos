using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RecetaMedica
    {
        public int IdReceta { get; set; }
        public String NombreMedicamento { get; set; }
        public int Cantidad { get; set; }
        public String Indicaciones { get; set; }
    }
}
