using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class ProxyClient
    {
        public void ClientCode(ISubject subject)
        {
            // ...

            subject.Request();

            // ...
        }
    }
}
