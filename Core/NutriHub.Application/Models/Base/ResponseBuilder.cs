using Newtonsoft.Json;
using System.Net;

namespace NutriHub.Application.Models.Base
{
    public class ResponseBuilder
    {
        [JsonProperty(PropertyName = "error")]
        public IList<string> Errors { get; set; }

        [JsonProperty(PropertyName = "status")]
        public int Status { get; private set; } = 200;

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; } = new object();

        public void SetStatus(HttpStatusCode statusCode)
        {
            Status = (int)Enum.Parse(typeof(HttpStatusCode), statusCode.ToString());
        }

        public void AddError(string error)
        {
            Errors ??= new List<string>();
            Errors.Add(error);
        }

        public void AddData(object obj, string key = "list")
        {
            Data = new Dictionary<string, object>()
            {
                {key,obj }
            };
        }
    }
}
