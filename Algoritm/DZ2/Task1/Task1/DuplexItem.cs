using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    public class Node<T>
    {
            public T Value { get; set; }
            public Node<T> NextNode { get; internal set; }
            public Node<T> PrevNode { get; internal set; }

        public Node(T value)
        {
            Value = value;
        }


        public Node(Node<T> node, T value)
        {
            Value = value;
            node = NextNode;
        }
        

        public override string ToString()
        {
            return Value.ToString();
        }

    }
    }
