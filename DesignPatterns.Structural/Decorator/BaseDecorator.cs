using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BaseDecorator : Notifier
    {
        protected Notifier component;

        public BaseDecorator(Notifier component)
            => this.component = component;

        public void SetNotifier(Notifier component)
            => this.component = component;
        public override string Notify()
            => this.component != null ? this.component.Notify() : String.Empty;

    }
}
