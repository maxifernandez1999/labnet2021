using Lab.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public interface IABMLogic<T> where T : class
    {
        DbSet<T> GetAll();
    }
}
