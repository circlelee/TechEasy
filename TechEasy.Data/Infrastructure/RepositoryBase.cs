using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;

namespace TechEasy.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private TechEasyContext dataContext;
        private readonly IDbSet<T> dbset;

        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected TechEasyContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }

        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset;
        }

        public virtual IQueryable<T> Get()
        {
            return dbset;
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetTop(Expression<Func<T, bool>> where, int count)
        {
            return dbset.Where(where).Take(count);
        }

        public virtual IEnumerable<T> GetTop<TOrderType>(Expression<Func<T, bool>> where, Expression<Func<T, TOrderType>> orderBy, int count, bool desc = false)
        {
            if (desc)
            {
                return dbset.Where(where).OrderByDescending(orderBy).Take(count).ToList();
            }
            else
            {
                return dbset.Where(where).OrderBy(orderBy).Take(count).ToList();
            }
        }

        public virtual IEnumerable<RE> QuerySQL<RE>(string command, params object[] parameters)
        {
            return (DataContext as IObjectContextAdapter).ObjectContext.ExecuteStoreQuery<RE>(command, parameters).ToList();
        }

        public virtual int ExecuteSQL(string command, params object[] parameters)
        {
            return (DataContext as IObjectContextAdapter).ObjectContext.ExecuteStoreCommand(command, parameters);
        }

    }
}
