using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, IRatingContext context)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                        new object[] { context });
            }
            catch(Exception ex)
            {
                return new UnknownPolicyRater(new RatingUpdater());
            }

            //switch (policy.Type)
            //{
            //    case PolicyType.Auto:
            //        return new AutoPolicyRater(engine, engine.Logger);

            //    case PolicyType.Land:
            //        return new LandPolicyRater(engine, engine.Logger);

            //    case PolicyType.Life:
            //        return new LifePolicyRater(engine, engine.Logger);

            //    case PolicyType.Flood:
            //        return new FloodPolicyRater(engine, engine.Logger);
            //    default:
            //        return new UnknownPolicyRater(engine, engine.Logger);
            //}
        }
    }
}
