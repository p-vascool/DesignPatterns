using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        private List<string> _collection = new List<string>();
        private bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }

        public List<string> GetItems()
        {
            return _collection;
        }
    }
}
