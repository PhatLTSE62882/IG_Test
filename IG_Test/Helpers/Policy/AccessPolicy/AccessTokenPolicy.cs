using IG_Test.Helpers.Shared.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.Helpers.Policy.AccessPolicy
{
    public class AccessTokenPolicy : AuthorizationHandler<IAccessTokenPolicy>
    {
        IHttpContextAccessor _httpContextAccessor;
        public AccessTokenPolicy(
            IHttpContextAccessor _httpContextAccessor
            )
        {
            this._httpContextAccessor = _httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IAccessTokenPolicy requirement)
        {
            try
            {
                HttpContext httpContext = _httpContextAccessor.HttpContext;
                string token = httpContext.Session.GetString(Constant_Login.LOGINTOKEN);

                if (token != null && token.Length > 0)
                {
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }
                context.Fail();
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                context.Fail();
                return Task.CompletedTask;
            }

        }
    }
}
