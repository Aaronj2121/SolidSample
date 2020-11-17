using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArdalisRating
{

    public class FilePolicySource : IPolicySource
    {
        //SRP Example
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
