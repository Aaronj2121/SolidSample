using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        //SRP example
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            Policy policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());

            return policy;
        }
    }
}
