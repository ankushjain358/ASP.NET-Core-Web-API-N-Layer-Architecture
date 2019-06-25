using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private SampleApplicationContext _context;
        private GenericRepository<Employees> _employeeRepository;

        public UnitOfWork(SampleApplicationContext context)
        {
            _context = context;
        }

        public IGenericRepository<Employees> EmployeeRepository
        {
            get
            {
                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new GenericRepository<Employees>(_context);
                }
                return _employeeRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
