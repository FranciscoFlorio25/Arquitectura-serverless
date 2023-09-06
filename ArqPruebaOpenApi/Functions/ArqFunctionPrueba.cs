using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ArqPruebaOpenApi.Functions
{
    public class ArqFunctionPrueba
    {
        private readonly ILogger _log;

        public ArqFunctionPrueba(ILogger log)
        {
            _log = log;
        }

        [FunctionName("ArqFunctionPrueba")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            _log.LogInformation("Testing... Testing.");

            //string name = req.Query["name"];

            // string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            // dynamic data = JsonConvert.DeserializeObject(requestBody);
            // name = name ?? data?.name; 

            string responseMessage = "look i worked!";

            return new OkObjectResult(responseMessage);
        }
    }
}
