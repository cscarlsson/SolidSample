using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string PolicyJson)
        {

            return JsonConvert.DeserializeObject<Policy>(PolicyJson,
                new StringEnumConverter());
        }
    }
}
