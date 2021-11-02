using System;
using System.Collections.Generic;

namespace AdapterTest
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {   
           if(!Hibernating)
            {
                Console.WriteLine("Big roar");
            }

        }
        public void LookAt(object objectToLookAt)
        {   if(!Hibernating)
            {
                Console.WriteLine("The bear is looking at "
                + objectToLookAt.ToString());
            }
        }
        public void GoTowards(object objectToWalkTowards)
        {
            if(!Hibernating)
            {
                Console.WriteLine("Bear goes after "
                + objectToWalkTowards.ToString());
            }
            
        }
        public bool TryEat(object objectToEat)
        {
            if(!Hibernating)
            {
                Console.WriteLine("Bear tries to eat  "
                + objectToEat.ToString());
            }

            return false;

        }
    }
}