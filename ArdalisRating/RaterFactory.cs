using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class RaterFactory
    {
        //Helps with SRP as switch statement in RaterEngine is not deciding which type of Rater to create
        //and the factory does this
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                    new object[] { engine, engine.Logger });
            }
            catch
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }
        }
    }

    public abstract class Rater
    {
        public readonly RatingEngine _engine;
        public  ConsoleLogger _logger;
        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }
        public abstract void Rate(Policy policy);
    }
}
