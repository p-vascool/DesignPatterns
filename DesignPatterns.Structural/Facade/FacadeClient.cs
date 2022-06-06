using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class FacadeClient
    {
        public static void ClientCode(Facade facade)
                => Console.Write(facade.Operation());

    }
}
