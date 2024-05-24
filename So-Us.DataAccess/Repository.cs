﻿using So_Us.DataAccess;

namespace SosuPower.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext sosuPowerContext;

        public Repository(DataContext sosuPowerContext)
        {
            this.sosuPowerContext = sosuPowerContext;
        }

        public void Add(T entity)
        {
            sosuPowerContext.Add(entity);
            sosuPowerContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            sosuPowerContext.Remove(entity);
            sosuPowerContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = GetBy(id);
            Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return sosuPowerContext.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return sosuPowerContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            sosuPowerContext.Update(entity);
        }
    }
}