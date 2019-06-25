using System;
using System.Collections.Generic;
using System.Text;
using SampleApplication.DTO;
using SampleApplication.Repository;
using System.Linq;
using AutoMapper;

namespace SampleApplication.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateEmployee(EmployeeDTO employee)
        {
            var employeeEntity= _mapper.Map<Employees>(employee);
            _unitOfWork.EmployeeRepository.Insert(employeeEntity);
            _unitOfWork.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employeeEntity = _unitOfWork.EmployeeRepository.Get(item => item.Id == id).FirstOrDefault();
            _unitOfWork.EmployeeRepository.Delete(employeeEntity);
            _unitOfWork.SaveChanges();
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            var employeeEntity = _unitOfWork.EmployeeRepository.Get(item => item.Id == id).FirstOrDefault();
            return _mapper.Map<EmployeeDTO>(employeeEntity);
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var employeeList = _unitOfWork.EmployeeRepository.Get().ToList();
            return _mapper.Map<List<EmployeeDTO>>(employeeList);
        }

        public void UpdateEmployee(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employees>(employee);
            _unitOfWork.EmployeeRepository.Update(employeeEntity);
            _unitOfWork.SaveChanges();
        }
    }
}
