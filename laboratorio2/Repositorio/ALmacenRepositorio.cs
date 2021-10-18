using laboratorio2.Data;
using laboratorio2.Dominio;
using laboratorio2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio2.Repositorio
{
    public class ALmacenRepositorio : IAlmacenPersona
    {
         AplicationDbContext apps;

        public ALmacenRepositorio(AplicationDbContext app)
        {
            this.apps = app;
        }

        public List<AlmacenPersona> ListaPersonas()
        {
            return apps.almacenPersonas.ToList();
        }

        public void save(AlmacenPersona ap)
        {
            apps.Add(ap);
            apps.SaveChanges();
        }
    }
}
