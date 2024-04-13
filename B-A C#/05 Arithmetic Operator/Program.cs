using System;
using static System.Console;

namespace ArithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Operators
            // variables / ভেরিয়েবল এবং values / মানের উপর অপারেশন করার জন্য Operators / অপারেটর ব্যবহার করা হয়।

            string firstName = "Md ";
            string secondName = "Salim ";
            string lastName = "Hossain";
            string fullName =firstName + secondName + lastName;
            // + operator টি strings গুলো কে সংযুক্ত করার জন্য ব্যবহার করা যেতে পারে। এটিকে concatenation বলা হয়।
            // লক্ষ্য করো যে আমরা প্রিন্টে firstName , secondName এবং lastName এর মধ্যে একটি স্পেস তৈরি করার জন্য "Md " এবং "Salim " এর পরে একটি স্পেস যোগ করেছি।
            WriteLine(fullName);
            WriteLine("================ \n");

            // Operator           Name                Description
            //   +            Addition             দুটি মানকে একসাথে যোগ করে।

            int firstNumber = 30;
            int scondNumber = 20;
            int result = firstNumber + scondNumber;
            //  সংখ্যার মানের জন্য, + চিহ্নটি গাণিতিক অপারেটর হিসাবে কাজ করে (লক্ষ্য করুন যে আমরা এখানে int (পূর্ণসংখ্যা) ভেরিয়েবল ব্যবহার করি):
            WriteLine(result);
            WriteLine("================ \n");

            // Operator           Name                Description
            //  -	            Subtraction	         একটি মান থেকে অন্য মান বাদ দেয়।

            int firstNumber1 = 30;
            int secondNumber1 = 20;
            int result1 = firstNumber1 - secondNumber1;
            WriteLine(result1);
            WriteLine("================ \n");
            // Operator           Name                Description
            //   *	          Multiplication	    দুটি মানের গুণফল বের করে।
            int firstNumber2 = 30;
            int secondNumber2 = 20;
            int result2 = secondNumber1 * secondNumber2;
            WriteLine(result2);
            WriteLine("================ \n");
            // Operator           Name                Description
            //   /	            Division	      একটি মানকে অন্য একটি দ্বারা ভাগ করুন।
            double firstNumber3 = 30;
            double secondNumber3 = 20;
            double result3 = firstNumber3 / secondNumber3;
            WriteLine(result3);



            //  using static System.Console; structure /গঠনপ্রণালী ব্যবহার করার কারণে Console ব্যবহার করা হচ্ছে না।
            ReadLine();
        }
    }
}
