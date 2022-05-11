using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MessageDemonstration
    {
        public void MessageDemo()
        {
            string message = "Hello <<name>>, We've Your Full Name as << full name >> in our system. your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine(message);
            Console.WriteLine("Enter The Name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter The Full Name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter The Mobile Number: ");
            string mobile = Console.ReadLine();
            message = message.Replace("<<name>>", name1).Replace("<< full name >>", name2);
            message = message.Replace("xxxxxxxxxx", mobile).Replace("01 / 01 / 2016", "07 / 05 / 2022");
            Console.WriteLine(message);
        }
    }
}
