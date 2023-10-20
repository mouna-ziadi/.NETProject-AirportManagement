using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService : Service<Plane>, IPlaneService
    {
        //IRepository<Plane> repository;
        //public PlaneService(IRepository<Plane> repository)
        //{
        //    this.repository = repository;

        //}
        IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
            //this.unitOfWork = unitOfWork;
        }
        //public void Add(Plane plane)
        //{
        //   //repository.Add(plane);
        //   //repository.Commit();
        //   unitOfWork.GetRepository<Plane>().Add(plane);
        //    unitOfWork.Save();
        //}

        //public void Delete(Plane plane)
        //{
        //   //repository.Delete(plane);
        //   // repository.Commit();
        //   unitOfWork.GetRepository<Plane>().Delete(plane); 
        //    unitOfWork.Save();
        //}

        //public List<Plane> GetAll()
        //{
        //    //return repository.GetAll();
        //    return unitOfWork.GetRepository<Plane>().GetAll();
        //}
    }
}
