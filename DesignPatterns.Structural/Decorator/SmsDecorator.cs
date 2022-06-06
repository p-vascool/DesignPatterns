using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(Notifier component)
            : base(component)
        {
        }

        public override string Notify()
            => $"- SMS notification added!\n{base.Notify()}";
    }
}
