﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);
        void Create(T obj);
        void Delete(T obj);
        void Edit(T obj);
        IEnumerable<T> GetByTagID(int id);
    }

}
