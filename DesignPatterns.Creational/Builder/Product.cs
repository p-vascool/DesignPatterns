using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part) => _parts.Add(part);
        public string ListParts() => $"Product parts: {string.Join(", ", _parts)} \n";

    }
}
