using System;
using ActivaCore.Domain;
using System.Collections.Generic;
namespace ActivaCore.Application
{
    public class EntidadService
    {
        public EntidadService(IGenericRepository<Entidad> repository)
        {
            Repository = repository;
        }
        public IGenericRepository<Entidad> Repository { get; }

        public IEnumerable<Entidad> GetList()
        {
            return Repository.Get();
        }
        public Entidad Get(object id)
        {
            return Repository.GetByID(id);
        }

        public void Create(string nombre)
        {
            Repository.Insert(new Entidad(nombre));
            Repository.Save();
        }

        public void Delete(Entidad entidad)
        {
            Repository.Delete(entidad);
            Repository.Save();
        }
    }



}
