using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;

namespace azure_functions_example.Models
{
    public class DummyModel
    {
        [OpenApiPropertyDescription("The number of Dummy")]
        public int Number { get; set; }

        [OpenApiPropertyDescription("The text of Dummy")]
        public string Text { get; set; }
    }
}
