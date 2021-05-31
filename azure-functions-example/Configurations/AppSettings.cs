using Microsoft.Azure.WebJobs.Extensions.OpenApi.Configurations.AppSettings.Extensions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Extensions.Configuration;

namespace azure_functions_example.Configurations
{
    public class AppSettings : OpenApiAppSettingsBase
    {
        public AppSettings()
            : base()
        {
            OpenApi = Config.Get<OpenApiSettings>("OpenApi");
            MongoDbConnectionString = Config.GetValue<string>("MongoDbConnectionString");
        }

        public virtual OpenApiSettings OpenApi { get; set; }
        public string MongoDbConnectionString { get; set; }
    }

    public class OpenApiSettings
    {
        public virtual string ApiKey { get; set; }
    }
}
