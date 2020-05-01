using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidades;
using capadato;
namespace capanegocio
{
    public class logicanegocioespecialidad
    {
        accesodatoespecialidad esp = new accesodatoespecialidad();
        public int insertarespecialidad(especialidad es)
        {
            return esp.insertarespecialidad(es);
        }
        public List<especialidad> listarespecialidad()
        {
            return esp.Listarespecialidad();
        }
        public int eliminarespecialidad(int codespecialidad)
        {
            return esp.eliminarespecialidad(codespecialidad);
        }
        public int editarespecialidad(especialidad es)
        {
            return esp.editarespecialidad(es);
        }
        public List<especialidad> buscarespcialidad(string dato)
        {
            return esp.buscarespecialidad(dato);
        }
    }
}

