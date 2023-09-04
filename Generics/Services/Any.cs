using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Services
{
    internal class Any<T> where T : class //T Should be class type
    {
        private T[] _items;
        public void AddItems(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else
            {
                var length = _items.Length;
                var destination = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    destination[i] = _items[i];
                }
                
                destination[destination.Length - 1] = item;
                _items = destination;
            }

        }
        public void RemoveItem(int position)
        {
            if (position < 0 || position > _items.Length - 1)
            {
                return;
            }
            var index = 0;
            var dest = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++)
            {
                if (position == i)
                {
                    continue;
                }
                else
                {
                    dest[index++] = _items[i];
                }
            }
            _items = dest;
        }

        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(i);
                if (i < _items.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

        }
        public bool isEmpty => _items is null || _items.Length == 0;
        public int Count => _items is null ? 0 : _items.Length;
    }
}
