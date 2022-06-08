using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        private int _position = -1;
        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection wordsCollection, bool reverse = false)
        {
            this._collection = wordsCollection;
            this._reverse = reverse;
            if (reverse)
                this._position = wordsCollection.GetItems().Count;
        }

        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int nextPosition = this._position + (this._reverse ? -1 : 1);
            if (nextPosition >= 0 && nextPosition < this._collection.GetItems().Count)
            {
                this._position = nextPosition;
                return true; 
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
