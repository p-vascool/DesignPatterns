using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }
        public string GetState()
        {
            return this._state;
        }
    }
}
