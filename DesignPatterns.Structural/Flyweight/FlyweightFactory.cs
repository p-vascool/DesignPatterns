using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.GetKey(elem)));
            }
        }

        public string GetKey(Car key)
        {
            var elemenst = new List<string>();

            elemenst.Add(key.Model);
            elemenst.Add(key.Color);
            elemenst.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elemenst.Add(key.Number);
                elemenst.Add(key.Owner);
            }

            elemenst.Sort();

            return String.Join("_", elemenst);
        }
        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = this.GetKey(sharedState);
            if (!flyweights.Any(x => x.Item2 == key))
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return this.flyweights.First(x => x.Item2 == key).Item1; 
        }
        public void ListFlyweights()
        {
            var count = flyweights.Count;

            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");

            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
