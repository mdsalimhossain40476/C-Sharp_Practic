using System;
using static System.Console;

namespace ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object numberOne = 10;
            object numberTwo = 20;
            /*
                যদি কোনো অবজেক্টের মধ্যে কোনো গাণিতিক/mathematical অপারেশন চালাতে চাওয়া হয়, তাহলে Explicit Casting (ম্যানুয়ালি) করে অপারেশনটি সম্পন্ন করতে হবে।

                কাস্টিং করার নিয়ম : ভেরিয়েবল এর শুরুতে () প্রথম ব্রাকেটের মধ্যে এর টাইপ বসাবো যেমন (int) ইন্টেজার।   কম্পাইল এখন বুঝতে পারছে এটা একটা Integer।
            */
            WriteLine( (int)numberOne+(int)numberTwo);

            
            numberOne = "Salim";
            WriteLine( numberOne.GetType());//ভেরিয়েবলকে দেখাবে এটা কোন টাইপের ভেরিয়েবল।

            numberTwo = 15.5;
            WriteLine( numberTwo.GetType());//ভেরিয়েবলকে দেখাবে এটা কোন টাইপের ভেরিয়েবল।

            WriteLine( numberOne+" , "+numberTwo);
            /*
                স্ট্রিং কে কনকেট করে প্রিন্ট করা । +" , "+  এটাকে বলে কনকেটিনিশ
                কনকেটিনিশন দুইটি ভ্যারিয়েবল কে জোড়া দিতে সাহায্য করে।
            */

            short shortNumber = -32768;
            WriteLine(shortNumber);//-32768 থেকে ৩২৭৬৭ ভেরিয়েবল তার ভ্যালু নিতে পারে নিতে পারে।


            ushort uShortNumber = 32767 * 2;
            WriteLine( uShortNumber); /*
                                        ushort Variable শর্ট ভ্যারিবল থেকে দ্বিগুণ বহন করতে পারে।
                                        এখানে উল্লেখ্য যে, ushort ভেরিবল কখনোই মাইনাস হবে না।
                                     */

            ReadLine();

           
        }
    }
}
