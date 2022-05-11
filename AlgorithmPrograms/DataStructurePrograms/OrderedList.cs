using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructurePrograms
{
    public class OrderedList<T> where T : IComparable<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T value)
            {
                data = value;
                next = null;
            }
        }
        public Node<T> head = null;
        public Node<T> tail = null;
        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void SortOrderedList()
        {
            Node<T> current = head, index = null;
            T temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;

                    while (index != null)
                    {
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }

        public void DisplaySort()
        {
            Node<T> current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
