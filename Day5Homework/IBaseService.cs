using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    public interface IBaseService<TEntity>
    {
        public void Add(TEntity myEntity);
        public void Update(TEntity myEntity);
        public void Delete(TEntity myEntity);
    }
}
