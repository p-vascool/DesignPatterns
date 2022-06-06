using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(Notifier component)
            : base(component)
        {
        }

        public override string Notify()
            => $"- Facebook notification added!\n{base.Notify()}";

    }
}
