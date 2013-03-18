using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace KnockoutSamples.Extensions
{
    public class JsonNetResult : JsonResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (JsonRequestBehavior == JsonRequestBehavior.DenyGet &&
                String.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "HTTP GET is not allowed. To allow it, use JsonRequestBehavior.AllowGet");
            }

            var response = context.HttpContext.Response;
            response.ContentType = String.IsNullOrWhiteSpace(ContentType) ? "application/json" : ContentType;

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data == null)
            {
                return;
            }

            var settings = new JsonSerializerSettings 
                {ContractResolver = new CamelCasePropertyNamesContractResolver()};

            var serialized = JsonConvert.SerializeObject(Data, settings);
            response.Write(serialized);
        }
    }
}