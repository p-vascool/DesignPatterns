using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
            => _sharedState = car;

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(_sharedState, Formatting.Indented);
            string u = JsonConvert.SerializeObject(uniqueState, Formatting.Indented);

            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
