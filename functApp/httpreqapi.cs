using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace functApp
{
    public class httpreqapi
    {
        private readonly ILogger<httpreqapi> _logger;

        public httpreqapi(ILogger<httpreqapi> logger)
        {
            _logger = logger;
        }

        [Function("httpreqapi")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
