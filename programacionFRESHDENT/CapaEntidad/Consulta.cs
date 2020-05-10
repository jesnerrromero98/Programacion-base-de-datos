using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consulta
    {
        public int IdConsulta { get; set; }
        public String TipoConsulta { get; set; }
        public int IdCita { get; set; }
        public int IdEspecialidad { get; set; }
    }
}
