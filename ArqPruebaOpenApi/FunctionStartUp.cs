using Application;
using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions.Extensions.Swashbuckle.Settings;
using Infraestructure;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(ArqPruebaOpenApi.FunctionStartUp))]

namespace ArqPruebaOpenApi
{
    public class FunctionStartUp : FunctionsStartup
    {

        public override void Configure(IFunctionsHostBuilder builder)
        {

            builder.Services.AddSwashBuckle(Assembly.GetExecutingAssembly(), opts =>
            {
                opts.AddCodeParameter = true;
                opts.Documents = new[]
                {
                   new SwaggerDocument
                   {
                       Name = "v1",
                       Title = "Swagger Document",
                       Description = "Swagger UI for Azure Functions",
                       Version = "v1",
                   }
                };
                opts.ConfigureSwaggerGen = x =>
                {
                    x.CustomOperationIds(apiDesc =>
                    {
                        return apiDesc.TryGetMethodInfo(out MethodInfo mInfo) ? 
                            mInfo.Name
                            : 
                            default(Guid).ToString();
                    });
                };
            });

            builder.Services.AddInfraestructure(builder.GetContext().Configuration);
            builder.Services.AddApplication();
        }
    }
}
