using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DemoFunctions
{
    public static class Add
    {
        [FunctionName("Add")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "add/num1/{num1}/num2/{num2}")] HttpRequest req,
            int num1,
            int num2,
            ILogger log)
        {
            var result = new OperationResult
            {
                Result = num1 + num2,
                TimeOnServer = DateTime.Now.ToString()
            };

            return new OkObjectResult(result);
        }
    }
}
