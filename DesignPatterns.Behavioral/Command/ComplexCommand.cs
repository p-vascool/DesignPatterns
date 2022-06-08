using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string a;
        private string b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this.a = a;
            this.b = b;
        }
        public void Execute()
        {
            Console.WriteLine("Complex command: Complex stuff should be executed by a receiver!");
            this._receiver.DoSomething(this.a);
            this._receiver.DoSomethingElse(this.b);
        }
    }
}
