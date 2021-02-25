using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }


        public DuplexLinkedList()
        {

        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        public interface ILinkedList
        {
            int GetCount(int value); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node<T> node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node<T> node); // удаляет указанный элемент
            Node<T> FindNode(Node<T> startNode, int searchValue); // ищет элемент по его значению
        }

        public void GetCount(T value)
        {
            var item = new Node<T>(value);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }
            Console.WriteLine(Count);
        }

        public void AddNode(T value)
        {
            var item = new Node<T>(value);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.NextNode = item;
            item.PrevNode = Tail;
            Tail = item;
            Count++;
        }

        public void AddNodeAfter(Node<T> node, T value)
        {
            var item = new Node<T>(node.NextNode, value);
            Tail.NextNode = item;
            item.PrevNode = Tail;
            Tail = item;
            Count++;
        }

        public void RemoveNode(Node<T> node)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(node.NextNode))
                {
                    current.PrevNode.NextNode = current.NextNode;
                    current.NextNode.PrevNode = current.PrevNode;
                    Count--;
                    return;
                }

                current = current.NextNode;
            }
        }


        public void RemoveNode(T index)
              {
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(index))
                {
                    current.PrevNode.NextNode = current.NextNode;
                    current.NextNode.PrevNode = current.PrevNode;
                    Count--;
                    return;
                }

                current = current.NextNode;
            }
        }

        public static Node<T> FindNode(Node<T> startNode, T searchValue)
        {
            var currentNode = startNode;

            while (currentNode != null)
            {
                if (currentNode.Value == null)
                    return currentNode;

                currentNode = currentNode.NextNode;
            }

            return null; // если ничего не нашли, то null

        }




    public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current;
                current = current.NextNode;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator(); 
        }
    }
}
