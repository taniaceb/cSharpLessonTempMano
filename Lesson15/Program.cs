using Lesson15.Class;
using System;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {

            try { 

            int[] masyvas = new int[3];
            int test = Convert.ToInt32(Console.ReadLine());
            masyvas[5] = test;

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"Klaida: {exception}"); 
            }
           catch (FormatException exception)
            {
                Console.WriteLine($"Klaida: {exception}"); 
            }


            /*Birthday birth = new Birthday();
                        
            Console.WriteLine(birth.month);

            Mounth mous = Mounth.April;
            Console.WriteLine(mous);*/



            /*

            TestClass test = new TestClass();
            test.PrintData();
            test.Age = 10;
            test.Numbers.Add(4);
            test.Numbers.Add(5);
            test.PrintData();
            

            TestStruct teststruct = new TestStruct("Sname");
            teststruct.PrintData();
            teststruct.Numbers.Add(8);
            teststruct.Numbers.Add(9);
            teststruct.Age = 15;
            teststruct.PrintData();

            Change();*/

        }

        static void Change()
        {
            TestClass test = new TestClass();
            test.Age = 10;
            test.Numbers.Add(4);
            test.Numbers.Add(5);
            test.PrintData();
        }
    }
}
