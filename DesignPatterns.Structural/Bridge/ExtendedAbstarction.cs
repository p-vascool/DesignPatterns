using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class ExtendedAbstarction : Abstraction
    {
        public ExtendedAbstarction(IImplementation implementation) 
            : base(implementation)
        {
        }
        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
