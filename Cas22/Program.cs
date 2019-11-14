using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste();
            ZadatakSumaListe();
            Console.ReadKey();
        }

        static void ZadatakSumaListe()
        {
            List<int> numbers = new List<int>();
            bool stayInLoop = true;
            string userEntry;
            int enteredNum;
            do
            {
                Console.WriteLine("Enter a number (leave blank to finish) > ");
                userEntry = Console.ReadLine();
                if (string.IsNullOrEmpty(userEntry))
                {
                    break;
                }
                enteredNum = Convert.ToInt32(userEntry);
                numbers.Add(enteredNum);
                
            } while (stayInLoop);

            Console.WriteLine("The sum of all entered numbers is {0}", CalculateSum(numbers));
        }

        static void ZadatakSumaListe2()
        {
            bool uslov;
            List<int> unetiBrojevi = new List<int>();
            int brojac = 0;

            do
            {
                Console.Write("Molim Vas unesite jedan broj: ");
                string vrednost = Console.ReadLine();

                if (vrednost != "")
                {
                    uslov = true;
                    int novaVrednost = Convert.ToInt32(vrednost);
                    unetiBrojevi.Add(novaVrednost);
                }
                else
                {
                    foreach (int iteracija in unetiBrojevi)
                    {
                        brojac += iteracija;
                    }
                    Console.WriteLine("Suma brojeva je: {0}", brojac);
                    break;
                }
            } while (uslov == false);

        }

        static int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Liste()
        {
            List<int> numbers = new List<int>();
            //List<object> objects = new List<object>();
            Object[] objects = new object[] { 1, "Some text" };

            numbers.Add(10);
            numbers.Add(25);
            numbers.Add(45);
            numbers.Add(2);
            numbers.Add(7);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Sort();

            Console.WriteLine("After calling Sort() method");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Array of various data types");
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine(objects[i]);
            }

            //Console.WriteLine("List of various data types");
            //objects.Add(10);
            //objects.Add("Some text");

            //foreach (var obj in objects)
            //{
            //    Console.WriteLine(obj);
            //}

        }

    }

}
