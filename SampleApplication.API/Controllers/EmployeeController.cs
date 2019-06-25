using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.Service;
using SampleApplication.DTO;
using SampleApplication.API.Infrastructure;

namespace SampleApplication.API.Controllers
{
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("list")]
        public ApiResponse<List<EmployeeDTO>> List()
        {
            var employeeList = _employeeService.GetEmployees();
            return new ApiResponse<List<EmployeeDTO>>(employeeList);
        }


        [HttpGet]
        [Route("{id}")]
        public ApiResponse<EmployeeDTO> Get(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            return new ApiResponse<EmployeeDTO>(employee);
        }

        [HttpPost]
        [Route("create")]
        public BaseResponse Post([FromBody]EmployeeDTO employee)
        {
            _employeeService.CreateEmployee(employee);
            return new BaseResponse  { Success = true };
        }

        [HttpPost]
        [Route("update")]
        public BaseResponse Update([FromBody]EmployeeDTO employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new BaseResponse { Success = true };
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}
