using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Airport.Security
{
    public class ApiKeyAuthFilter : Attribute, IAuthorizationFilter
    {
        private readonly IConfiguration _configuration;

        public ApiKeyAuthFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, out var extractedApiKey))
            {
                context.Result = new UnauthorizedObjectResult("Api key missing");
                return;
            }

            var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKeyHeaderName);

            if (!string.IsNullOrEmpty(apiKey) && !apiKey.Equals(extractedApiKey))
            {
                context.Result = new UnauthorizedObjectResult("Api-Key is invalid");
                return;
            }

        }
    }
}
