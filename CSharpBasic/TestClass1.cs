using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
       public void Add()
        {
            Console.WriteLine("Empty method");
        }
        public void Add(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Empty method with two parameters " + result);
        }
    }
    //testy
    class TestClass2
    {
        private int i = 0;

        public void SetValue(int value)
        {
            i = value;
        }

        public void GetValue()
        {
            Console.WriteLine("The Value of i is: " + i);
        }

        public void TestCase1(string result)
        {
            Console.WriteLine("Executing TEstCase one " + result);
        }

        public void TestCase2(string result)
        {
            Console.WriteLine("Executing TEstCase two " + result);
        }


    }

}
