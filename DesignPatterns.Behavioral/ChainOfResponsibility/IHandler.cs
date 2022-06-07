﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler next);
        object Handle(object request);
    }
}
