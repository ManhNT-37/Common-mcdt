using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMC.Common
{
   
    // RULES
    // If success, status code = 1, message is empty, data is not null
    // If error, status code = 0, message is error message, data is null

    public class Response<T> : Response
    {
        [JsonProperty("data")]
        public T Data { get; private set; }

        public Response(int status, string message = null, T data = default(T))
            : base(status, message)
        {
            Data = data;
        }
    }
   
    public class DVCQG_Response
    {
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public DVCQG_Response(string error_code, string message = null)
        {
            ErrorCode = error_code;
            Message = message;
        }
    }
    public class Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public Response(int status, string message = null)
        {
            Status = status;
            Message = message;
        }
    }
    

}
