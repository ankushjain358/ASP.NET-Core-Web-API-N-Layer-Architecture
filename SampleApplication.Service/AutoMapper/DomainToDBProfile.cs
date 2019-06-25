using AutoMapper;
using SampleApplication.DTO;
using SampleApplication.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication.Service
{
    public class DomainToDBProfile : Profile
    {
        public DomainToDBProfile()
        {
            CreateMap<EmployeeDTO, Employees>();
        }
    }
}
