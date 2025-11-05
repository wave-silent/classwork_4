using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classwork_4
{
    internal class Example
    {
        private int _x;
        private int _y;


        public Example()
        {
            _x = 0;
            _y = 0;
        }

        public Example(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void print()
        {
            Console.WriteLine(_x + " " + _y);

        }
        // Унарные операции 
        public static Example operator ++(Example example)
        {
            // так нельзя делать 
            //example._x++;

            Example ex = new Example(++example._x, ++example._y);

            return ex;

            //return new Example(++example._x, ++example._y); 
        }
        public static Example operator --(Example example)
        {
            return new Example(--example._x, --example._y); 
        }

        // бинарные операции
        public static Example operator +(Example ex1, Example ex2)
        {
            return new Example(ex1._x + ex2._x, ex1._y + ex2._y);
        }

        public static Example operator -(Example ex1, Example ex2)
        {
            return new Example(ex1._x - ex2._x, ex1._y - ex2._y);
        }
        // Леосторонняя
        public static Example operator +(Example ex1, int n)
        {
            return new Example(ex1._x + n, ex1._y + n);
        }
        // Правосторонняя
        public static Example operator +(int n, Example ex1)
        {
            return ex1 + n;
        }
        public static bool operator >(Example ex1, Example ex2)
        {
            return (ex1._x + ex1._y) > (ex2._x + ex2._y);
        }

        public static bool operator <(Example ex1, Example ex2)
        {
            return (ex1._x + ex1._y) < (ex2._x + ex2._y);
        }

        // Приведение типа 
        // Явная операция - explicit. Неявная implicit
        public static explicit operator int(Example e)
        {
            return e._x;
        }

        public static implicit operator bool(Example e)
        {
            return e._x == e._y;
        }



    }
}
