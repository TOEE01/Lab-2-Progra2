using laboratorio2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio2.Servicios
{
    interface IAlmacenPersona
    {
        void save(AlmacenPersona ap);

        List<AlmacenPersona> ListaPersonas();
    }
}
