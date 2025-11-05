using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classwork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Example ex1 = new Example(10, 20);
            Example ex2 = new Example(20, 30);
            Example ex3 = new Example();

            ex3 = ++ex1;

            ex3.print();

            ex3 = --ex3;

            ex3.print();

            ex3 = ex1 + ex2;

            ex3.print();

            ex3 = ex1 - ex2;

            ex3.print();

            ex2 = ex1 + 10;

            ex2.print();

            ex2 = 10 + ex1;

            ex2.print();

            bool b = ex1 > ex2;

            Console.WriteLine(b);
            // явное приведение
            int a = (int)ex2;

            Console.WriteLine(a);

            // неявное приведение
            bool z = ex2;

            Console.WriteLine(z);*/

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            // list.Remove(0) - удаляет конкретное значение

            // list.RemoveAt() - удаляет по индексу 

            list.Remove(0);
            list.RemoveAt(1);

            list[0] = 1;

            //Возвращает кол-во списка/коллекции
            int x = list.Count;

            HashSet<int> set1 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(1); // 1 2 3

            //set[0] - не можем обращаться 

            HashSet<int> set2 = new HashSet<int>();
            set2.Add(3);
            set2.Add(4);
            set2.Add(5); // 3 4 5

            //set1.UnionWith(set2); // 1 2 3 4 5

            //set1.IntersectWith(set2); // 3

            set1.ExceptWith(set2); // 1 2 

            // Вывод такой же как и у словарей
   
            // Словари 
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            // Примеры на телефоне 

        }
    }
}
