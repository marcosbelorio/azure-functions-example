using System;

using Newtonsoft.Json;

namespace azure_functions_example.Models
{
    public class DummyDictionaryResponseModel
    {
        public Guid? Id { get; set; }

        [JsonRequired]
        public string JsonRequiredValue { get; set; }
    }
}
