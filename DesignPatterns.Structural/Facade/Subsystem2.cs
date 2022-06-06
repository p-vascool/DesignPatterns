using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Subsystem2
    {
        public string Operation1()
            => "Subsystem2: Ready!\n";

        public string OperationZ()
            => "Subsystem1: Fire!\n";
    }
}
