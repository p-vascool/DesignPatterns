using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Context
    {
        private State _state;
        public Context(State state)
            => this.TransitionTo(state);

        public void TransitionTo(State state)
        {

            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetState(this);
        }

        public void FirstRequest()
            => this._state.FirstHandle();

        public void SecondRequest()
            => this._state.SecondHandle();
    }
}
