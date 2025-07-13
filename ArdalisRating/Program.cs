using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            IPolicySource policySource = new FilePolicySource();

            logger.Log("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine(logger, policySource);
            engine.Rate();

            if (engine.Rating > 0)
            {
                logger.Log($"Rating: {engine.Rating}");
            }
            else
            {
                logger.Log("No rating produced.");
            }

        }
    }
}
