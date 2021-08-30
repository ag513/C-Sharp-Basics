using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass a = new AClass();
            a.MyNumber = 5;
            a.InterFaceMethod();
            Console.Read();
        }
    }
    interface IShape
    {
        int MyNumber { get; set; }
        void InterFaceMethod();
    }


    class AClass : IShape
    {

        private int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        public void InterFaceMethod()
        {
            Console.WriteLine("The number is {0}.", MyNumber);
        }

    }
}
