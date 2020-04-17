using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidades
{
    public class cita
    {
        public int idcitas { get; set; }
        public DateTime nuevacitas { get; set; }
        public DateTime fechacita { get; set; }
        public DateTime horadisponible { get; set; }
        public int precio { get; set; }
        public int idregpaciente { get; set; }

    }
}
