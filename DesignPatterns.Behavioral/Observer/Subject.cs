using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : ISubject
    {
        public int State { get;set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
            Console.WriteLine("Subject: Attached an observer.");
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ChangeSubjectState()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(TimeSpan.FromSeconds(3).Milliseconds);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
