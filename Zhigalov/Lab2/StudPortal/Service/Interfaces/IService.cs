﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IService<T>
    {
        void Create(T target);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
