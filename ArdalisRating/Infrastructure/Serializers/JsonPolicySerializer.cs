using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
  
    public class JsonPolicySerializer : IPolicySerializer
    {
        //SRP example
        public Policy GetPolicyFromString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
           
        }
    }
}
