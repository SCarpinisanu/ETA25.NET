//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Tema1
{
    
    public class Tema1
    {
        [Test]
        public void PrimaTema()
        {
            string firstName = "Sorin";
            string lastName = "Carpinisanu";
            string age = "57";
            string gender = "Male";

            Console.WriteLine("Hello," + "\n");


            Console.WriteLine("Please input your First name: " + "\n" + firstName);
            Console.ReadLine();
            
            Console.WriteLine("Please input your Last name: " + "\n" + lastName);
            //Console.ReadLine();

            Console.WriteLine("Please input your age: " + "\n" + age);
            //Console.ReadLine();
            
            Console.WriteLine("Please input your gender: " + "\n" + gender);
            //Console.ReadLine();

            Console.WriteLine("Your details are as follows:");
            Console.WriteLine("    - First Name : " + firstName);
            Console.WriteLine("    - Last Name  : " + lastName);
            Console.WriteLine("    - Gender     : " + gender);
            Console.WriteLine("You will be " + (Convert.ToInt32(age) + 20) + " years old in 20 years!");
        }
    }
}
