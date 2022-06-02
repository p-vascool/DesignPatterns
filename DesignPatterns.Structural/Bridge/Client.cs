﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Client
    {

        public void ClientCode(Abstraction abstraction) => Console.Write(abstraction.Operation());
    }
}
