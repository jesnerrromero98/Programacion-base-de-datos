using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadato;
using capaentidades;

namespace capanegocio
{
    public class logicanegocioexpediente
    {
        accesodatoexpediente exp = new accesodatoexpediente();
        public int insertarexpediente(expediente ex)
        {
            return exp.insertarexpediente(ex);
        }
        public List<expediente> listarexpediente()
        {
            return exp.Listarexpediente();
        }
        public int eliminarexpediente(int idexpediente)
        {
            return exp.eliminarexpediente(idexpediente);
        }
        public int editarexpediente(expediente ex)
        {
            return exp.editarexpediente(ex);
        }
        public List<expediente> buscarexpediente(string dato)
        {
            return exp.buscarexpediente(dato);
        }
    }
}
}
