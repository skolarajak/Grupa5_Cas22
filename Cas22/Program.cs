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
            Liste();
            Console.ReadKey();
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
