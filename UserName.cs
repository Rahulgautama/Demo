using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class UserName
    {
        public static void DisplayUser() {
            Console.WriteLine("Please Enter the name");
            string name = Console.ReadLine();

            if (name.Length > 2 && name.Length < 5)
            {
                Console.WriteLine("Hello" + name + "How are you?");
                Console.WriteLine("Hello{0}, How are you?" + name);
            }
            else if (name.Length > 5)
            {
                Console.WriteLine("The name is greater than 5 character");
            }
            else
            {
                Console.WriteLine("The name is less than 3 characters");
            }
        }
    }
}
