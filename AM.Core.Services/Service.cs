using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class Service<T> : IService<T> where T : class
    {
        IUnitOfWork unitOfWork;
        public Service(IUnitOfWork unitOfWork)
        {this.unitOfWork = unitOfWork;}
        public void Add(T t)
        { unitOfWork.GetRepository<T>().Add(t);
          unitOfWork.Save();}
        public void Delete(T t)
        {   unitOfWork.GetRepository<T>().Delete(t);
            unitOfWork.Save();}
        public T Get(int id)
        { return unitOfWork.GetRepository<T>().Get(id); }
        public T Get(string id)
        { return unitOfWork.GetRepository<T>().Get(id);}
        public List<T> GetAll()
        { return unitOfWork.GetRepository<T>().GetAll(); }
        public void Update(T t)
        {   unitOfWork.GetRepository<T>().Update(t);
            unitOfWork.Save(); }
    }
}
