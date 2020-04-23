using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public abstract class Rater
    {
        internal RatingEngine _engine { get; }
        internal ConsoleLogger _logger { get; }
        public Rater(RatingEngine engine, ConsoleLogger logger) 
        {
            _engine = engine;
            _logger = logger;
        }
        public abstract void Rate(Policy policy);
    }
}