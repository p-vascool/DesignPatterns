using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class LinuxFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
           return new LinuxButton();
        }

        public ICheckBox CreateCheckBox()
        {
           return new LinuxCheckBox();
        }
    }
}
