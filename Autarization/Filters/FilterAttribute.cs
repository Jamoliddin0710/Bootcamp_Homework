using Autarization.Context;
using Autarization.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Autarization.Filters
{
   
    public class FilterAttribute : ActionFilterAttribute
    {
        private readonly UserDbContext _context;

        public FilterAttribute(UserDbContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
          if(!context.HttpContext.Request.Headers.ContainsKey("Key"))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

          var key = context.HttpContext.Request.Headers["Key"];

          if(!_context.Users.ToList().Any(user=>user.Key == key))
            {
                context.Result = new UnauthorizedResult();
            }
        }

    }
}
