﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T t);
        T Get(int id) ;
        T Get(string id);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();
        //void Commit();

    }
}
