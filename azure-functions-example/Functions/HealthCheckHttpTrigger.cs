using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace azure_functions_example.Functions
{
    public class HealthCheckHttpTrigger
    {
        private readonly HealthCheckService _healthCheck;
        public HealthCheckHttpTrigger(HealthCheckService healthCheck)
        {
            _healthCheck = healthCheck;
        }

        [FunctionName("health")]
        [OpenApiOperation(operationId: "health", tags: new[] { "healthcheck" }, Summary = "Get application health")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(string), Description = "The OK response")]        
        public async Task<IActionResult> Run(
           [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
           ILogger log)
        {
            log.Log(LogLevel.Information, "Received heartbeat request");

            return new OkObjectResult(await _healthCheck.CheckHealthAsync());
        }
    }
}
