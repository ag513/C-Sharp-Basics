using System;

namespace PassByReferenceAndValue
{
    class ValueRefernce
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("a inside method is " + a);
        }

        public void PassByReference(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = " + b[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int[] b = { 1, 2, 3 };

            ValueRefernce obj = new ValueRefernce();
            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);

            Console.WriteLine("\n\n");
            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);
        }
    }
}
