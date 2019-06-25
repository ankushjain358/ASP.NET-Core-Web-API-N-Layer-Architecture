using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.API.Infrastructure
{
    public class ApiResponse<T> : BaseResponse where T : class
    {
        public ApiResponse() { }

        public ApiResponse(T data, bool success = true)
        {
            this.Success = success;
            this.Data = data;
        }

        public ApiResponse(string message, T data, bool success = true)
        {
            this.Success = success;
            this.Data = data;
            this.Message = message;
        }

        public T Data { get; set; }
    }
}
