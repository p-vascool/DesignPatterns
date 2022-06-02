using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation() => "ConcreteImplementationA: The result in platform B.\n";
    }
}
