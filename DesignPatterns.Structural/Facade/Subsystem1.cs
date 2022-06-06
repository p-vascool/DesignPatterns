using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Subsystem1
    {
        public string Operation1()
            => "Subsystem1: Ready!\n";

        public string OperationN()
            => "Subsystem1: Go!\n";
    }
}
