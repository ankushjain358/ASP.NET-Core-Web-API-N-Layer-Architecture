using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.API.Infrastructure
{
    public class BaseResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public List<string> ValidationErrors { get; set; }
    }
}
