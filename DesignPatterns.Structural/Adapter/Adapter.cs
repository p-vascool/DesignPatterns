using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
            => _adaptee = adaptee;
        public string GetRequest() => $"This is {_adaptee.GetSpecificRequest()}!";
    }
}
