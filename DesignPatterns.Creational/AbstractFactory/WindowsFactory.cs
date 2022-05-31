using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new MacintoshButton();
        }

        public ICheckBox CreateCheckBox()
        {
           return new MacintoshCheckBox();
        }
    }
}
