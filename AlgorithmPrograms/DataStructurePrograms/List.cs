using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructurePrograms
{
    public class List<T>
    {
        public void MainList()
        {
            UnOrderedList<int> list = new UnOrderedList<int>();
            bool check = true;
            Console.WriteLine("1.Simple Linked List\n2.Add in reverse order\n3.Insert number at particular position\n4.Delete a number at particular position\n5.Delete Last Node\n6.Search for the element\n7.Delete new element");
            while (check)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.AddData(30);
                        list.AddData(56);
                        list.AddData(70);
                        list.Display();
                        break;
                    case 2:
                        list.ReverseOrder(56);
                        list.ReverseOrder(30);
                        list.ReverseOrder(70);
                        break;
                    case 3:
                        list.AddData(56);
                        list.AddData(70);
                        int a = list.SearchData(56);
                        list.InsertAtParticularPosition(a + 1, 30);
                        list.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter The Position of An Element");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeAtParticularPosition(position);
                        list.Display();
                        break;
                    case 5:
                        list.AddData(56);
                        list.AddData(30);
                        list.AddData(70);
                        list.RemoveLastNode();
                        list.Display();
                        break;
                    case 6:
                        list.AddData(30);
                        list.AddData(56);
                        list.AddData(70);
                        int value = list.SearchData(30);
                        list.Display();
                        Console.WriteLine("Element is in" + value);
                        break;
                    case 7:
                        list.AddData(56);
                        list.AddData(30);
                        list.AddData(40);
                        list.AddData(70);
                        list.DeleteNodeAtParticularPosition(2);
                        list.Display();
                        break;
                }
            }
        }
    }
}
