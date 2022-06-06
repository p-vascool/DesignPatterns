using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteComponent : Notifier
    {
        public override string Notify()
        {
            return "Concrete operation";
        }
    }
}
