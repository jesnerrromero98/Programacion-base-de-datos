using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidades
{
    public class recetamedica
    {
        public int idreceta { get; set; }
        public string nombremedicamento { get; set; }
        public int cantidad { get; set; }
        public string indicaciones { get; set; }
        public int idregpaciente { get; set; }

    }
}
