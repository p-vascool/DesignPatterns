using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsCheckBox : ICheckBox
    {
        public string CheckBoxWithButton(IButton collaborator)
        {
            var result = collaborator.ButtonFunction();

            return $"The result of the {nameof(WindowsCheckBox)} collaborating with the ({result})";
        }

        public string CheckBoxFunction()
        {
            return $"The result of the product {nameof(WindowsCheckBox)}.";
        }
    }
}
