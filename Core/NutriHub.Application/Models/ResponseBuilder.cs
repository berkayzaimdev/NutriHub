using Newtonsoft.Json;
using System.Net;

namespace NutriHub.Application.Models
{
    public class ResponseBuilder
    {
        [JsonProperty(PropertyName = "error")]
        public IList<string> Errors { get; set; }

        [JsonProperty(PropertyName = "status")]
        public int Status { get; private set; } = 200;

        [JsonProperty(PropertyName = "data")]
        public Object Data { get; set; } = new Object();

        public void SetStatus(HttpStatusCode statusCode)
        {
            Status = (int)Enum.Parse(typeof(HttpStatusCode), statusCode.ToString());
        }

        public void AddError(string error)
        {
            Errors ??= new List<string>();
            Errors.Add(error);
        }

        public void AddData(Object obj, string key = "list")
        {
            Data = new Dictionary<String, Object>()
            {
                {key,obj }
            };
        }
    }
}
