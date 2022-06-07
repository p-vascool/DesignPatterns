using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }    
        }

        public IHandler SetNext(IHandler next)
        {
            this._nextHandler = next;

            return this._nextHandler;
        }
    }
}
