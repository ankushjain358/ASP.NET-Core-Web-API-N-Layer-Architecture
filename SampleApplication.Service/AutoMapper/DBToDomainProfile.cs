using AutoMapper;
using SampleApplication.DTO;
using SampleApplication.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication.Service
{
    public class DBToDomainProfile : Profile
    {
        public DBToDomainProfile()
        {
            CreateMap<Employees, EmployeeDTO>();
        }
    }
}
