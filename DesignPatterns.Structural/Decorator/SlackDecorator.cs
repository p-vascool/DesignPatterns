using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier component)
            : base(component)
        {
        }

        public override string Notify()
                => $"- Slack notification added!\n{base.Notify()}";
    }
}
