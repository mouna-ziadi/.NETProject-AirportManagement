using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        AMContext cpx;
        public UnitOfWork(AMContext cpx)
        {   this.cpx = cpx;          }
        public void Dispose()
        {
            cpx.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(cpx);
        }

        public void Save()
        {
            cpx.SaveChanges();
        }
    }
}
