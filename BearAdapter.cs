using System;
namespace AdapterTest
{
    public class BearAdapter : IDog
    {
        private IBear bear;
        public void Bark()
        {
            bear.Roar();
        }
        public void Fetch(object objectToFetch)
        {
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }
        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
    }
}