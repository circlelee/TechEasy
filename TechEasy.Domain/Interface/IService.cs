using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace TechEasy.Domain.Interface
{
    public interface IService<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(long Id);
        T GetById(string Id);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> Get();
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetTop(Expression<Func<T, bool>> where, int count);
        IEnumerable<T> GetTop<TOrderType>(Expression<Func<T, bool>> where, Expression<Func<T, TOrderType>> orderBy, int count, bool desc = false);
        IEnumerable<RE> QuerySQL<RE>(string command, params object[] parameters);
        int ExecuteSQL(string command, params object[] parameters);
        IEnumerable<T> GetList(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAllList();
    }
}
