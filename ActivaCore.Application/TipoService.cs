using System;
using ActivaCore.Domain;
using System.Collections.Generic;

namespace ActivaCore.Application
{
    public class TipoService
    {
        public TipoService(IGenericRepository<Tipo> repository)
        {
            Repository = repository;
        }
        public IGenericRepository<Tipo> Repository { get; }


        public IEnumerable<Tipo> GetList()
        {
            return Repository.Get();
        }

        public Tipo Get(object id)
        {
            return Repository.GetByID(id);
        }

        public void Create(string descripcion, int? idSubTipo)
        {
            Repository.Insert(new Tipo(descripcion, idSubTipo));
            Repository.Save();
        }
        public void Update(Tipo tipo)
        {
            Repository.Update(tipo);
            Repository.Save();
        }
    }
}
