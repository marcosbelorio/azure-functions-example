using Newtonsoft.Json;

namespace azure_functions_example.Models
{
    public class DummyArrayResponseModel
    {
        public string Id { get; set; }

        [JsonRequired]
        public string JsonRequiredValue { get; set; }
    }
}
