using Frameworks;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServiceHost
{
    public class SecurityPageFilter : IPageFilter
    {
        private readonly IAuthHelper _authHelper;

        public SecurityPageFilter(IAuthHelper authHelper)
        {
            _authHelper = authHelper;
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            //var needpermission = (NeedsPermissionAttribute)context
            //    .HandlerMethod.MethodInfo.GetCustomAttributes(typeof(NeedsPermissionAttribute));
            //var accountPermissions = _authHelper.GetPermissions();
            //if (needpermission == null)
            //{
            //    return;
            //}
            //if (!accountPermissions.Any(x => x != needpermission.Permission))
            //{
            //    context.HttpContext.Response.Redirect("/Account");
            //}
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }
    }
}
