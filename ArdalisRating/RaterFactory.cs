using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolyciRater"),
                    new object[] { engine, engine.Logger });
            }
            catch
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }  
        }
    }
}