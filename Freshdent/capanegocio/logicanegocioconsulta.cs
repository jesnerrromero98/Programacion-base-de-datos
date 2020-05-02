using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadato;
using capaentidades;

namespace capanegocio
{
    public class logicanegocioconsulta
    {
        accesodatoconsulta con = new accesodatoconsulta();

        public int insertarconsulta(consulta co)
        {
            return con.insertarconsulta(co);
        }
        public List<consulta> listarconsulta()
        {
            return con.Listarconsulta();
        }
        public int eliminarconsulta(int idconsulta)
        {
            return con.eliminarconsulta(idconsulta);
        }
        public int editarconsulta(consulta co)
        {
            return con.editarconsulta(co);
        }
        public List<consulta> buscarconsulta(string dato)
        {
            return con.buscarconsulta(dato);
        }
    }
}
}
