using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MediatR;
using Application.UseCases.Products.GetProduct;
using ArqPruebaOpenApi.Extension;
using Domain.Entities;
using Azure.Core;
using Application.UseCases.Products.AddProduct;

namespace ArqPruebaOpenApi.Functions
{
    public class ArqFunctionPrueba
    {
        private readonly ILogger _log;
        private readonly IMediator _mediator;

        public ArqFunctionPrueba(ILogger log, IMediator mediator)
        {
            _log = log;
            _mediator = mediator;
        }

        [FunctionName("ArqFunctionPrueba")]
        public async Task<IActionResult> GetProducts(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "product/get")] HttpRequest req)
        {
            _log.LogInformation("Testing... Testing.");

            var responseMessage = await _mediator.Send(new GetProductRequest()).ToHttpResult();

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("ArqFunctionPrueba")]
        public async Task<IActionResult> PostProduct(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "product/post")] AddProductRequest req)
        {
            _log.LogInformation("Testing... Testing.");


            var responseMessage = await _mediator.Send(req).ToHttpResult();

            return new OkObjectResult(responseMessage);
        }
    }
}
