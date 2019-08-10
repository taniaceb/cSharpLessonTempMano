using System;
using System.IO;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText(@"..\test2.txt", "Hello");
            
            string failoTekstas = File.ReadAllText(@"..\test2.txt");
            Console.WriteLine(failoTekstas);

            File.AppendAllText(@"..\test2.txt", "C#");


            File.WriteAllText(@"..\test1.txt", "New file");
            File.Copy(@"..\test1.txt", @"..\test3.txt");

            File.Move(@"..\test3.txt", @"..\test4.txt");

            if (File.Exists(@"..\test1.txt"))
            {
                File.Delete(@"..\test1.txt");
            }





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
