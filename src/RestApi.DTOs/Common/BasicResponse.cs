using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RestApi.DTOs.Common
{
    public class BasicResponse : IBasicResponse
    {
        [Display(Order = 1)]
        [JsonProperty(Order = 1)]
        public string ReturnCode { get; set; }
        [Display(Order = 2)]
        [JsonProperty(Order = 2)]
        public string Message { get; set; }
        [Display(Order = 3)]
        [JsonProperty(Order = 3)]
        public string Description { get; set; }

        public BasicResponse()
            : this("0", string.Empty, string.Empty)
        {
        }

        public BasicResponse(BasicResponse basicResponse) : this(
            basicResponse?.ReturnCode ?? "0",
            basicResponse?.Message,
            basicResponse?.Description
        )
        {
        }

        public BasicResponse(string returnCode, string message, string description)
        {
            this.ReturnCode = returnCode;
            this.Message = message;
            this.Description = description;
        }
    }
}
