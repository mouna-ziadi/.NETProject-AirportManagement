
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        AMContext cpx;
        public Repository(AMContext cpx)
        {this.cpx = cpx;}
        public void Add(T t)
        {         cpx.Add(t); }
        //public void Commit()
        //{ cpx.SaveChanges(); }
        public void Delete(T t)
        {   cpx.Remove(t);}
        public T Get(int id)
        {return (T)cpx.Find(typeof(T),id);}
        public T Get(string id)
        {return (T)cpx.Find(typeof(T), id);}
        public List<T> GetAll()
        {return cpx.Set<T>().ToList(); }
        public void Update(T t)
        { cpx.Update(t);}
    }
}
