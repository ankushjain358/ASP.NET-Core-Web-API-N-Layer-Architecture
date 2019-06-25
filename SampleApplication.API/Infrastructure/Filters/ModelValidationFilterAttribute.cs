using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.API.Infrastructure
{
    public class ModelValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Where(a => a.Value.Errors.Count > 0).SelectMany(x => x.Value.Errors).Select(x => x.ErrorMessage).ToList();
                context.Result = new OkObjectResult(new BaseResponse
                {
                    Success = false,
                    Message = "Please correct following errors:", //TODO: Use constants here
                    ValidationErrors = errors
                });
            }

            base.OnActionExecuting(context);
        }
    }
}
