using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    public class Item<T>
    {
        private T data = default(T);

        public T Value
        {
            get => data;
            set { if (value != null) data = value; else throw new ArgumentNullException(nameof(value)); }

        }

        public Item<T> NextItem { get; set; }

        public Item(T data)
        {
         Value = data;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
