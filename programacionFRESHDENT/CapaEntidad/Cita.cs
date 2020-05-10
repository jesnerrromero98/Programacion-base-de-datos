using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime NuevaCita { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime HoraDisponible { get; set; }
        public int Precio { get; set; }
        public int Idexpediente { get; set; }
        public int IdEspecialidad { get; set; }
    }
}
