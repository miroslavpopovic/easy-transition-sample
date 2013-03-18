using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace KnockoutSamples.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object model)
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            return JsonConvert.SerializeObject(model, settings);
        }
    }
}