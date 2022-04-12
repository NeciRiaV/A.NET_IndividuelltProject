using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.NET___IndividuelltProject.API.Services
{
    public interface Iiproject<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<ICollection> GetSingel(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
        Task<IEnumerable<T>> GetSingelOne(int id);
        Task<T> GetOne(int id);
        Task<int> GetDate(int id, int week);
    }
}
