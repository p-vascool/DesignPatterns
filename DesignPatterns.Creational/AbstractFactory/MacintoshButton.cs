using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacintoshButton : IButton
    {
        public string ButtonFunction()
        {
            return "This is Macintosh Button";
        }
    }
}
