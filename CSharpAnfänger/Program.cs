using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnfänger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] stringArray = new string[10];
            //ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("String 1");
            arrayList.Add("String 2");
            arrayList.Add("5");
            arrayList.Add(2);
            arrayList.Add(new Random());
            arrayList.Add(new object());
            arrayList.Add(true);

            foreach (var item in arrayList)
            {
                if(item.GetType() == typeof(string))
                {
                    Console.WriteLine(item);
                }
            }

            ArrayList intArrayList = new ArrayList();
            intArrayList.Add(1);
            intArrayList.Add(2);
            intArrayList.Add(3);

            //List
            List<string> stringList = new List<string>();
            stringList.Add("String 1");
            stringList.Add("String 2");
            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            //Stack
            //Queue

            //HashTable
            //Dictionary


            Console.ReadKey();
        }
    }
}
