using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ClassA
    {
        private int privateNum = 1;
        public int publicNum = 2;
        protected int protectedNum = 3;
    }
    class ClassB : ClassA
    {
        public void PrintMessages()
        {
            //This is ok
            Console.WriteLine(publicNum);
            //This is ok
            Console.WriteLine(protectedNum);
            //This is NOT ok
            Console.WriteLine(privateNum);
        }
    }

    class ClassC
    {
        ClassA a = new ClassA();
        public void PrintMessages()
        {
            //This is ok
            Console.WriteLine(a.publicNum);
            //This is NOT ok
            Console.WriteLine(a.protectedNum);
            //This is NOT ok
            Console.WriteLine(a.privateNum);
        }
    }


}
