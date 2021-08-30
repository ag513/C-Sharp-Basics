using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            // MyAbstractClass b = new MyAbstractClass();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();
        }
    }

    abstract class MyAbstractClass
    {
        private string message = "Hello c#";
        public void PrintMessage() {
            Console.WriteLine(message);
        }
        public abstract void PrintMessageAbstract();
    }
   
    class Class1 : MyAbstractClass
    {
        public override void PrintMessageAbstract()
        {
          Console.WriteLine("c# is fun");
        }
    }
}
