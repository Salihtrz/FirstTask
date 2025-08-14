using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
