using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Resolvers;

using Newtonsoft.Json.Serialization;

namespace azure_functions_example.Models.Examples
{
    public class CategoryExample : OpenApiExample<Category>
    {
        public override IOpenApiExample<Category> Build(NamingStrategy namingStrategy = null)
        {
            this.Examples.Add(OpenApiExampleResolver.Resolve("first", new Category() { Id = 123, Name = "Hello World" }, namingStrategy));

            return this;
        }
    }
}
