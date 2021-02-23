using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    class Program
    {
        public class Node
        {
            internal object NextItem;

            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }

        }
        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        public interface ILinkedList
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
       //     Node FindNode(int searchValue); // ищет элемент по его значению
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetCount());

            Console.WriteLine("Введите число которое хочет добавить");
            string value1 = Console.ReadLine();
            int value = Convert.ToInt32(value1);
            AddNode(value);
            Console.ReadLine();

            Console.WriteLine("Введите число которое хочетe удалить");
            string value3 = Console.ReadLine();
            int index = Convert.ToInt32(value3);
            RemoveNode(index);
            Console.ReadLine();

            Console.WriteLine("Введите число которое хочетe удалить");
            string value4 = Console.ReadLine();
            int index3 = Convert.ToInt32(value4);
            RemoveNode(node);
            Console.ReadLine();

        }


            private LinkedListNode<int> current;

            public object sentence { get; private set; }
        public LinkedListNode<int> NextNode { get; private set; }

        public static int GetCount()
            {
                int[] words =
                    { 1, 2, 5, 10, 25, 50 };
                LinkedList<int> sentence = new LinkedList<int>(words);
                Display(sentence, "The linked list values:");
                Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
                    sentence.Contains(5));

                Display(sentence, "Test 1: Add 'today' to beginning of the list:");

                return 0;
            }


             public static void AddNode(int value)
             {
                  int[] words =
                         { 1, 2, 5, 10, 25, 50 };
                  LinkedList<int> sentence = new LinkedList<int>(words);

                  sentence.AddFirst(value);
                  Display(sentence, $"Test 1: Добавлено {value} в начало списка:");
            }


            public void AddNodeAfter(Node startNode, int value)
            {

                    var node = startNode;

                   while (node.NextItem != null)
                 {
                node = (Node)node.NextItem;
                 }

                 int[] words =
                              { 1, 2, 5, 10, 25, 50 };
                LinkedList<int> sentence = new LinkedList<int>(words);
                sentence.AddAfter(current, value);
                IndicateNode(node.NextNode, value);
                Display(sentence, $"Test 1: Добавлено {value} в начало списка:");
            }



            public static void RemoveNode(int index)
            {
                int[] words =
                         { 1, 2, 5, 10, 25, 50 };
                LinkedList<int> sentence = new LinkedList<int>(words);
                sentence.Remove(index);
                Display(sentence, $"Test 1: Добавлено {value} в начало списка:");
            }

            public static void RemoveNode(Node node)
            {
                int[] words =
                                 { 1, 2, 5, 10, 25, 50 };
                LinkedList<int> sentence = new LinkedList<int>(words);
                sentence.Remove(NextNode);
                Display(sentence, "Test 14: Remove node that has the value '3':");
                Display(sentence, $"Test 1: Добавлено {NextNode} в начало списка:");
        }

           public Node FindNode(int searchValue) // Метод получения i-ого элемента.
          {
                var currentNode = startNode;

        	    while(currentNode != null)
        	{
            	if (currentNode.Value == searchValue)
                	return currentNode;

            	currentNode = currentNode.NextItem;
        	}

        	return null; // если ничего не нашли, то null
            }



            private static void Display(LinkedList<int> words, string test)
            {
                Console.WriteLine(test);
                foreach (int word in words)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            private static void IndicateNode(Node node, int test)
            {
                Console.WriteLine(test);
                if (node.List == null)
                {
                    Console.WriteLine("Node '{0}' is not in the list.\n",
                        node.Value);
                    return;
                }

                StringBuilder result = new StringBuilder("(" + node.Value + ")");
                LinkedListNode<int> nodeP = node.Next;

                while (nodeP != null)
                {
                    result.Insert(0, nodeP.Value + " ");
                    nodeP = nodeP.Previous;
                }

                node = node.Next;
                while (node != null)
                {
                    result.Append(" " + node.Value);
                    node = node.Next;
                }

                Console.WriteLine(result);
                Console.WriteLine();
            }


        


    }
}


