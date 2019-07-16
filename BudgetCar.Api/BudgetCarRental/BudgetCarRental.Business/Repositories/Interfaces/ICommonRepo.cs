using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCarRental.Business.Repositories.Interfaces
{
    public interface ICommonRepo
    {
        bool IsValid<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
