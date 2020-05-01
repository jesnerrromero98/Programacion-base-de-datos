using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidades;
using capadato;

namespace capanegocio
{
    public class logicanegocioreceta
    {
        accesodatorecetamedica rec = new accesodatorecetamedica();
        public int insertarreceta(recetamedica re)
        {
            return rec.insertarrecetamedica(re);
        }
        public List<recetamedica> listarreceta()
        {
            return rec.Listarrecetamedica();
        }
        public int eliminarreceta(int idreceta)
        {
            return rec.eliminarrecetamedica(idreceta);
        }
        public int editarreceta(recetamedica re)
        {
            return rec.editarrecetamedica(re);
        }
        public List<recetamedica> buscarreceta(string dato)
        {
            return rec.buscarrecetamedica(dato);
        }
    }
}
}
