using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation() => "ConcreteImplementationA: The result in platform A.\n";
    }
}
