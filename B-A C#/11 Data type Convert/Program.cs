using System;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    C# Type Casting
                    Type casting এটি একটি প্রোগ্রামিং প্রক্রিয়া যা ডেটা টাইপের একটি মানকে আরেক ডেটা টাইপে পরিণত করে। 
                    যখন আপনি একটি ভ্যারিয়েবল বা মানকে একটি ডেটা টাইপ থেকে অপর ডেটা টাইপে পরিণত করেন, 
                    তখন আপনি ডেটা টাইপ স্পেসিফিকেশন দেওয়া যেতে পারে, যা প্রোগ্রামের সঠিক কাজের জন্য গুরুত্বপূর্ণ হতে পারে।
        
            */
            //  C# এ, দুই ধরনের কাস্টিং আছে:
            //  1.      Implicit Casting (স্বয়ংক্রিয়ভাবে)
            //  2.      Explicit Casting (ম্যানুয়ালি)


            //   Implicit Casting (স্বয়ংক্রিয়ভাবে) - একটি ছোট টাইপকে একটি বড় টাইপের সাইজে রূপান্তর করে
            //   char -> int -> long -> float -> double
            //  Implicit Casting : একটি ছোট আকারের টাইপকে একটি বড় আকারের টাইপে পাঠানোর সময় স্বয়ংক্রিয়ভাবে ইমপ্লিসিট ক্যাস্টিং করা হয়:
            int intNum = 20;
            long longNum = 200;
            longNum = intNum;
            WriteLine(longNum);  // //  Output :  20
            WriteLine("========== \n");

            //  Explicit Casting (ম্যানুয়ালি) - একটি বড় টাইপকে একটি ছোট টাইপের সাইজে রূপান্তর করে ।
            //  double -> float -> long -> int -> char
            int intNumber = 13;
            long longNumber = 5;
            //intNumber = Convert.ToInt32(longNumber);  //  Output :  5
            intNumber = (int)longNumber;                //  Output :  5
            WriteLine(intNumber);
            WriteLine("========== \n");

            float floatNumber = 10.667f;
            double doubleNumber = 16.60d;
            //floatNumber = (float)doubleNumber;          //  Output :  16.6
            floatNumber = Convert.ToInt32(doubleNumber);  //  Output :  17
            WriteLine(floatNumber);
            WriteLine("========== \n");

            string strNumber = "15";
            intNumber = int.Parse(strNumber);              // int.Parse শুধুমাত্র string কি Convert করার জন্য ব্যবহৃত হবে।
            WriteLine(intNumber);                          //  Output :  15
            WriteLine("========== \n");

             string tryNumber = "20";        //  Output :  Converted
            // string tryNumber = "20a";       //  Output :  Not Converted
            int result = 0;
            bool isConverted = int.TryParse(tryNumber, out result);
            if (isConverted) 
            {
                WriteLine("Converted");
            }
            else
            {
                WriteLine("Not Converted");
            }
            WriteLine("========== \n");

            string date = "01/09/23 10:20";  // Date কে Convert করার জন্য
            DateTime dateTime = Convert.ToDateTime(date);
            WriteLine(dateTime); // Output :   01 / 09 / 2023 10:20:00 am



            ReadLine();

        }
    }
}
