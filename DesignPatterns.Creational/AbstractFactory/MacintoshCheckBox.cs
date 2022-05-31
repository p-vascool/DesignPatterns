﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacintoshCheckBox : ICheckBox
    {
        public string CheckBoxWithButton(IButton collaborator)
        {
            var result = collaborator.ButtonFunction();

            return $"The result of the {nameof(MacintoshCheckBox)} collaborating with the ({result})";
        }

        public string CheckBoxFunction()
        {
            return $"The result of the product {nameof(MacintoshCheckBox)}";
        }
    }
}
