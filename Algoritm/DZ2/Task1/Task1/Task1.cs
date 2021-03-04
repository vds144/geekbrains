using System;
using GeekBrainsTests;

namespace HW2
{
	public class Task1 : ILinkedList
	{
		private Node StartNode { get; set; }
		private Node EndNode { get; set; }

		public void PrintList()
		{
			var curNode = StartNode;

			while (curNode != null)
			{
				Console.Write($" {curNode.Value}");
				curNode = curNode.NextNode;
			}
			Console.Write("\n");
		}

		public int GetCount()
		{
			int counter = 0;
			var curNode = StartNode;

			while (curNode != null)
			{
				counter++;
				curNode = curNode.NextNode;
			}

			return counter;
		}

		public void AddNode(int value)
		{
			var newNode = new Node { Value = value };
			if (this.StartNode == null)
			{
				this.StartNode = newNode;
			}
			if (this.EndNode != null)
			{
				newNode.PrevNode = this.EndNode;
				this.EndNode.NextNode = newNode;
				this.EndNode = newNode;
			}
			else
			{
				this.EndNode = this.StartNode;
			}
		}

		public void AddNodeAfter(Node node, int value)
		{
			if (node.NextNode == null)
			{
				var newNode = new Node { Value = value, PrevNode = node };
				node.NextNode = newNode;
			}
			else
			{
				var prevNode = node;
				var nextNode = node.NextNode;
				var newNode = new Node { Value = value, PrevNode = prevNode, NextNode = nextNode };
				prevNode.NextNode = newNode;
				nextNode.PrevNode = newNode;
			}
		}

		public void RemoveNode(int index)
		{
			int counter = 0;
			var curNode = StartNode;

			while (curNode != null)
			{
				if (counter == index)
				{
					RemoveNode(curNode);
					return;
				}
				counter++;
				curNode = curNode.NextNode;
			}

			throw new System.ArgumentException("Элемент отсутсвует в списке");
		}

		public void RemoveNode(Node node)
		{
			var prevNode = node.PrevNode;
			var nextNode = node.NextNode;
			if (this.StartNode == node)
			{
				this.StartNode = node.NextNode;
			}
			if (this.EndNode == node)
			{
				this.EndNode = node.PrevNode;
			}
			if (prevNode != null)
			{
				prevNode.NextNode = nextNode;
			}
			if (nextNode != null)
			{
				nextNode.PrevNode = prevNode;
			}
		}

		public Node FindNode(int searchValue)
		{
			var curNode = StartNode;

			while (curNode != null)
			{
				if (searchValue == curNode.Value)
				{
					return curNode;
				}
				curNode = curNode.NextNode;
			}

			throw new System.ArgumentException("Элемент отсутсвует в списке");
		}
	}
}

