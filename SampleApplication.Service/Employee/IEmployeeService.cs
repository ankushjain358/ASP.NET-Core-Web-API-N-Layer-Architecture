using SampleApplication.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication.Service
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees();
        EmployeeDTO GetEmployeeById(int id);
        void CreateEmployee(EmployeeDTO employee);
        void UpdateEmployee(EmployeeDTO employee);
        void DeleteEmployee(int id);
    }
}
