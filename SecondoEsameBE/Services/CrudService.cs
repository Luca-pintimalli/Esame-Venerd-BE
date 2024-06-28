using System.Collections.Generic;
using System.Linq;
using SecondoEsameBE.Entities;

namespace SecondoEsameBE.Services
{
    public class CrudService<T> : ICrudService<T> where T : Article
    {
        protected static readonly List<T> entities = new List<T>();
        private static int lastId = 0;

        public void Create(T entity)
        {
            entity.Id = ++lastId;
            entities.Add(entity);
        }

        public T GetById(int entityId) => entities.Single(e => e.Id == entityId);

        public IEnumerable<T> GetAll() => entities;
    }
}

