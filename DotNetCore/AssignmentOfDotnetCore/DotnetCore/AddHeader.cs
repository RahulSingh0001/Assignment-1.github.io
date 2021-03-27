using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentOfDotnetCore
{
    // Custom Attribute for add the name in each header
    public class AddHeaderAttribute : ResultFilterAttribute
    {

        public AddHeaderAttribute()
        {

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            // Add name in header
            context.HttpContext.Response.Headers.Add("Author", "RahulSingh");
            base.OnResultExecuting(context);
        }
    }
}
