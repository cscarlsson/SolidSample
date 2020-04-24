using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class RatingUpdater : IRatingUpdater
    {
        ILogger Logger = new ConsoleLogger();
        public void UpdateRating(decimal rating)
        {
            Logger.Log("New policy rating is: " + rating.ToString());   
        }
    }
}
