using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DemoFunctions
{
    public static class SayHello
    {
        [FunctionName("SayHello")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "hello/name/{name}")]
            HttpRequest req,
            string name,
            ILogger log)
        {
            return new OkObjectResult($"Hello from Punta Cana, {name}");
        }
    }
}
