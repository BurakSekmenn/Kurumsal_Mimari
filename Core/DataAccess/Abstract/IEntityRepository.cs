﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> Getlist(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void add(T entity);
        void Update(T entity);
        void delete(T entity);

    }
}
