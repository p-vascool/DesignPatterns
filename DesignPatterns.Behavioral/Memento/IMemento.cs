using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}
