﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        void AddPartA();
        void AddPartB();
        void AddPartC();
    }
}
