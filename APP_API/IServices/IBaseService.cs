using System;
using System.Collections.Generic;
namespace AppData.Serviece.Interfaces
{
    public interface IBaseService<T,ID>
    {
        T Save(T item);
        T GetById(ID id);
        IEnumerable<T> GetAll();
        void Remove(ID id);
        PagedList<T> GetPaged(int page, int size);
    }
}