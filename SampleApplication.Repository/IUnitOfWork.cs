using SampleApplication.Repository;
using System;

namespace SampleApplication.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Employees> EmployeeRepository { get; }
        void SaveChanges();
    }
}
