using Lesson16.Banks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson16
{
    public delegate void DoOperation(int m1, int m2);
    public delegate void EvenHandler(string message);



    class Program
    {
        static void MyMultiply(int m1, int m2)
        {
            Console.WriteLine(m1 * m2);
        }

        static void MySum(int m1, int m2)
        {
            Console.WriteLine(m1 + m2);
        }


        static void Main(string[] args)
        {

        /*    Bank myBank = new Bank("BankName", 1000);
            myBank.Add(500);*/




           DoOperation myDelegate = new DoOperation(MyMultiply);
            myDelegate(4, 5);
            myDelegate += MySum;
            myDelegate(7, 8);


          
            /*
            LinkedList<String> linked = new LinkedList<String>();
            linked.AddFirst("One");
            linked.AddLast("Ten");

            LinkedListNode<String> newNode = linked.First;
            linked.AddAfter(newNode, "Two");

            LinkedListNode<String> newNode1 = linked.Last;
            linked.AddBefore(newNode1, "Nine");

            foreach(string value in linked)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("***********************");

            linked.Remove(newNode1);

            foreach (string value in linked)
            {
                Console.WriteLine(value);
            }

            linked.RemoveFirst();

            Console.WriteLine("***********************");

            
            foreach (string value in linked)
            {
                Console.WriteLine(value);
            }

            linked.RemoveLast();

            Console.WriteLine("***********************");


            foreach (string value in linked)
            {
                Console.WriteLine(value);
            }

            linked.Clear();
            foreach (string value in linked)
            {
                Console.WriteLine(value);
            }*/


            /* Dictionary<int, string> week = new Dictionary<int, string>()
            {
                {1, "Monday" },
                {2,"Tuesday" },
                {3, "Wensday" },
                {4,"Thursday" },
                {5,"Friday" },
                {6, "Sutarday" },
                {7,"Sunday" }
            };

            Dictionary<int, string> arr = new Dictionary<int, string>();
            arr.Add(0, "one");
            arr.Add(5, "two");

            Console.WriteLine(week[5]);
            Console.WriteLine(week.Count);

            week.Remove(6);
            foreach (KeyValuePair<int,string> keyValuePair in week)
            {
                Console.WriteLine(keyValuePair.Key + " - " +keyValuePair.Value);
            }

            Console.WriteLine("******************************");

            week.Add(6, "Sestadienis");
            foreach(KeyValuePair<int,string> keyValuePair1 in week)
            {
                Console.WriteLine(keyValuePair1.Key + " - " + keyValuePair1.Value);
            }


           if (week.Contains(new KeyValuePair<int,string>(5,"Friday")))
            {
                Console.WriteLine("Yra");
            }
           else
            {
                Console.WriteLine("Nera");
            }


            if(week.ContainsKey(7))
            {
                Console.WriteLine("Toks raktas yra");
            }


            if(week.ContainsValue("Monday"))
            {
                Console.WriteLine("Tokia reiksme yra");
            }

            foreach(KeyValuePair<int,string> keyValuePair2 in arr)
            {
                Console.WriteLine(keyValuePair2.Key + " " + keyValuePair2.Value);
            }

            arr.Clear();*/




            /* File.WriteAllText(@"..\test2.txt", "Hello");
            
            string failoTekstas = File.ReadAllText(@"..\test2.txt");
            Console.WriteLine(failoTekstas);

            File.AppendAllText(@"..\test2.txt", "C#");


            File.WriteAllText(@"..\test1.txt", "New file");
            File.Copy(@"..\test1.txt", @"..\test3.txt");

            File.Move(@"..\test3.txt", @"..\test4.txt");

            if (File.Exists(@"..\test1.txt"))
            {
                File.Delete(@"..\test1.txt");
            }*/





            /*MyLibrary.Enemy testEnemy1 = new MyLibrary.Enemy("Enemy");

            MyUtils.Enemy testEnemy2 = new MyUtils.Enemy();

            testEnemy2.Name = "Enemy2";
           
            

            testEnemy1.PrintName();
            testEnemy2.DoStuff();*/



            /*
            string wordsLine;

            wordsLine = "String object is a sequential collection of System.Char objects which represent a string.";

            char test = wordsLine[5];
            Console.WriteLine($"wordsLine[5]: {test}");
            int totalChars = wordsLine.Length;
            Console.WriteLine($"wordsLine.Length: {totalChars}");

            string testStr = wordsLine.Substring(7, 6);
            Console.WriteLine($"wordsLine.Substring(7, 6): {testStr}");

            string testStr1 = wordsLine.Remove(25);
            Console.WriteLine($"wordsLine.Remove(25): {testStr1}");

            string testStr2 = wordsLine.Replace('o', '@');
            Console.WriteLine($"wordsLine.Replace('o', '@'): {testStr2}");

            string testStr3 = wordsLine.Insert(7, "zxzxzxzxz");
            Console.WriteLine($"wordsLine.Insert(7, zxzxzxzxz): {testStr3}");

            string testStr4 = "Atttsts";
            string testStr5 = "BBBsskdskd";
            string testStr6 = String.Concat(testStr4, " ", testStr5);
            Console.WriteLine($"String.Concat(testStr4,  testStr5):  {testStr6}");*/

        }

       
    }
}
