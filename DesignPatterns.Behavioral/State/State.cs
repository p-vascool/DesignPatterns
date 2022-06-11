using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public abstract class State
    {
        protected Context _context;

        public void SetState(Context context)
            => this._context = context;

        public abstract void FirstHandle();
        public abstract void SecondHandle();
    }
}
