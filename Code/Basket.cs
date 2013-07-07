using System;
using System.Collections.Generic;

namespace Code
{
    public class Basket
    {
        private readonly IList<string> _items = new List<string>();

        public void Add(string item)
        {
            _items.Add(item);
        }

        public void ForEachItem(Action<string> action)
        {
            foreach (var item in _items)
            {
                action(item);
            }
        }
    }
}
