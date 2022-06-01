using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void AddPartA() => _product.AddPart("Part A");
        public void AddPartB() => _product.AddPart("Part B");
        public void AddPartC() => _product.AddPart("Part C");

        public Product GetProduct()
        {
            var product = this._product;
            this.Reset();
            return product;
        }
        public void Reset() => this._product = new();
    }
}
