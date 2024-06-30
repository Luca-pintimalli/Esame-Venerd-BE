using System.Collections.Generic;

namespace SecondoEsameBE.Services
{
    public interface ICrudService<T>
    {
        void Create(T entity);
        T GetById(int entityId);
        IEnumerable<T> GetAll();
    }
}

