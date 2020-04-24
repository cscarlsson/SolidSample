using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class DefaultRatingContext : IRatingContext
    {
        public RatingEngine Engine { get; set; }
        public ConsoleLogger Logger => new ConsoleLogger();

        public Rater CreateRaterForPolicy(Policy policy, IRatingContext Context)
        {
            return new RaterFactory().Create(policy, Context);
        }

        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return new JsonPolicySerializer().GetPolicyFromJsonString(policyJson);
        }

        public Policy GetPolicyFromXmlString(string PolicyXml)
        {
            throw new NotImplementedException();
        }

        public string LoadPolicyFromFile()
        {
            return new FilePolicySource().GetPolicyFromSource();
        }

        public string LoadPolicyFromURI(string uri)
        {
            throw new NotImplementedException();
        }

        public void Log(string Message)
        {
            new ConsoleLogger().Log(Message);
        }
    }
}
