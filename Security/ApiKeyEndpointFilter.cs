using Microsoft.AspNetCore.Mvc;

namespace Airport.Security
{
    public class ApiKeyEndpointFilter : IEndpointFilter
    {
        private readonly IConfiguration _configuration;

        public ApiKeyEndpointFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, out var extractedApiKey))
            {
                return new UnauthorizedHttpObjectResult("Api key missing");
            }

            var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKeyHeaderName);

            if (!string.IsNullOrEmpty(apiKey) && !apiKey.Equals(extractedApiKey))
            {
                return new UnauthorizedHttpObjectResult("Api key in invalid");
            }
            return await next(context);
        }
    }
}
