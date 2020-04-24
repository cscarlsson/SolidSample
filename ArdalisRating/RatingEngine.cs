using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public IRatingContext Context { get; set; } = new DefaultRatingContext();
        public ILogger Logger = new ConsoleLogger();
        public decimal Rating { get; set; }
        public RatingEngine()
        {
            Context.Engine = this;
        }
        public void Rate()
        {
            Logger.Log("Starting rate.");

            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = Context.LoadPolicyFromFile();

            var policy = Context.GetPolicyFromJsonString(policyJson);

            var rater = Context.CreateRaterForPolicy(policy, Context);

            rater.Rate(policy);

            Logger.Log("Rating completed.");
        }
    }
}
