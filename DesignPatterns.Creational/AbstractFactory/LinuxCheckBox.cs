using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class LinuxCheckBox : ICheckBox
    {
        public string CheckBoxFunction()
        {
            return $"The result of the product {nameof(LinuxCheckBox)}.";
        }

        public string CheckBoxWithButton(IButton collaborator)
        {
            var result = collaborator.ButtonFunction();

            return $"The result of the {nameof(LinuxCheckBox)} collaborating with the ({result})";
        }
    }
}
