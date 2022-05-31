using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class SeaLogistics : Logisticts
    {
        public override ITransport FactoryMethod()
        {
             return new Truck();
        }
    }
}
