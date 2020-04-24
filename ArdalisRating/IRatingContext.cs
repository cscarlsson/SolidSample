using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public interface IRatingContext
    {
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);
        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXmlString(string PolicyXml);
        Rater CreateRaterForPolicy(Policy policy, IRatingContext Context);
        RatingEngine Engine { get; set; }
    }
}
