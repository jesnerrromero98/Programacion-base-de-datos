using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidades;
using capadato;

namespace capanegocio
{
    public class logicanegocioregpaciente
    {
        accesodatoregpaciente reg = new accesodatoregpaciente();
        public int insertarregpaciente(registropaciente re)
        {
            return reg.insertarpaciente(re);
        }
        public List<registropaciente> listarregpaciente()
        {
            return reg.Listarpaciente();
        }
        public int eliminarregpaciente(int idregpaciente)
        {
            return reg.eliminarpaciente(idregpaciente);
        }
        public int editarregpaciente(registropaciente re)
        {
            return reg.editarpaciente(re);
        }
        public List<registropaciente> buscarregpaciente(string dato)
        {
            return reg.buscarpaciente(dato);
        }
    }
}

