using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidades;
using capadato;

namespace capanegocio
{
    public class logicanegociocita
    {
        accesodatocita cit = new accesodatocita();

        public int insertarcita (cita ci)
        {
            return cit.insertarcita(ci);
        }
        public List<cita> listarcita()
        {
            return cit.Listarcita();
        }
        public int eliminarcita(int idcita)
        {
            return cit.eliminarcita(idcita);
        }
        public int editarcita(cita ci)
        {
            return cit.editarcita(ci);
        }
        public List<cita> buscarcita (string dato)
        {
            return cit.buscarcita(dato);
        }
    }
}
