using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
            => _implementation = implementation;

        public virtual string Operation() => "Abstract: Base operation with:\n" + _implementation.OperationImplementation();

    }
}
