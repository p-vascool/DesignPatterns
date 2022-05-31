using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new WindowsFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new MacintoshFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the third factory type...");
            ClientMethod(new LinuxFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckBox();

            Console.WriteLine(productB.CheckBoxFunction());
            Console.WriteLine(productB.CheckBoxWithButton(productA));
        }
    }
}
