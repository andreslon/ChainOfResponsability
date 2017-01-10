﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Repositories.Interfaces
{
    public interface IRepository<T>  
    { 
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id); 
    }
}
