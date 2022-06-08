using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class CareTaker
    {
        private List<IMemento> _mementoList = new List<IMemento>();
        private Originator _origininator = null;

        public CareTaker(Originator originator)
        {
            this._origininator = originator;
        }

        public void BackUp()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this._mementoList.Add(_origininator.Save());
        }
        public void Undo()
        {
            if (this._mementoList.Count == 0)
                return;

            var memento = this._mementoList.Last();
            this._mementoList.Remove(memento);
            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());
            try
            {
                this._origininator.Restore(memento);
            }
            catch (Exception ex)
            {
                this.Undo();
                throw;
            }
        }
        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementoList)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
