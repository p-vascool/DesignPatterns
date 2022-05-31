﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class LinuxButton : IButton
    {
        public string ButtonFunction()
        {
            return "This is Linux Button";
        }
    }
}
