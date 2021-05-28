using System;

using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using azure_functions_example.Models.Examples;

namespace azure_functions_example.Models
{
    [OpenApiExample(typeof(DummyStringModelExample))]
    public class DummyStringModel
    {
        public string StringValue { get; set; }

        public Uri UriValue { get; set; }
    }
}
