using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        public string GetSpecificRequest() => "Specific Request.";
    }
}
