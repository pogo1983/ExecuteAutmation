using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {

       
        static void Main(string[] args)
        {

            TestClass1 testClass = new TestClass1();
            testClass.Add(12, 12);
            testClass.Add();
           // NewMethod();
            Console.Read();

        }




        private static void NewMethod()
        {
            TestClass2 class1 = new TestClass2();
            class1.TestCase2("Passed");
            class1.TestCase2("Failed");


            class1.SetValue(20);
            class1.GetValue();


            TestClass2 class2 = new TestClass2();
            class2.SetValue(30);
            class2.GetValue();

            Console.Write("Hello Pogo");



        }
    }
}
