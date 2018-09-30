using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ApiSGEVAC.Repository
{
    public interface IRepository<T> where T : class 
    {
        T GetById(int id);
        IEnumerable<T> List();        
        void Add(T entity);
        void Delete(int id);
        void Edit(T entity);
        
    }
}