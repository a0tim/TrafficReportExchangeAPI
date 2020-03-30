using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrafficReportExchangeAPI.App_Code {
    public class AuthorizationFilter : IAuthorizationFilter {
        public void OnAuthorization(AuthorizationFilterContext context) {
            // 如果驗證失敗，可以讓 pipeline 短路
            if (!context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues token)) {
                context.Result = new UnauthorizedResult();
                return;
            }
            if (token != clsFunction.getAPIInfo("futek").apiKey) {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
    }
}
