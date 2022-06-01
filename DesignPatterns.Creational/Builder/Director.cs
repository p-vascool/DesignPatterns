using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director()
        {

        }

        public IBuilder Builder { set => _builder = value; }

        public void BuildMinimalVaiableProduct()
        {
            _builder.AddPartA();
        }

        public void BuildMaxVaiableProduct()
        {
            _builder.AddPartA();
            _builder.AddPartB();
            _builder.AddPartC();
        }
    }
}
