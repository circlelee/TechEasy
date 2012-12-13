using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Interface
{
    public abstract class ServiceBase<T>
        where T : class
    {
        private readonly IRepository<T> repository;
        private readonly IUnitOfWork unitOfWork;
        protected ServiceBase(IRepository<T> repository,IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public virtual void Add(T entity)
        {
            repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            repository.Add(entity);
        }
        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            repository.Delete(where);
        }
        public virtual T GetById(long Id)
        {
            return repository.GetById(Id);
        }
        public virtual T GetById(string Id)
        {
            return repository.GetById(Id);
        }
        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return repository.Get(where);
        }
        public virtual IQueryable<T> Get()
        {
            return repository.Get();
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return repository.GetMany(where);
        }

        public IEnumerable<T> GetTop(Expression<Func<T, bool>> where, int count)
        {
            return repository.GetTop(where, count);
        }

        public IEnumerable<T> GetTop<TOrderType>(Expression<Func<T, bool>> where, Expression<Func<T, TOrderType>> orderBy, int count, bool desc = false)
        {
            return repository.GetTop(where, orderBy, count, desc);
        }

        public IEnumerable<RE> QuerySQL<RE>(string command, params object[] parameters)
        {
            return repository.QuerySQL<RE>(command, parameters);
        }
        public int ExecuteSQL(string command, params object[] parameters)
        {
            return repository.ExecuteSQL(command, parameters);
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> where)
        {
            return GetMany(where).ToList();
        }
        public IEnumerable<T> GetAllList()
        {
            return GetAll().ToList();
        }

    }
}
