using System;
using static System.Console;

namespace VarType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    অবজেক্টের ভেরিয়েবলের উপর মাউস রাখলে শুধুমাত্র অবজেক্টের টাইপ দেখা যায়। 
                    কিন্তু ভ্যারের ভেরিয়েবলের উপর মাউস রাখলে এটি (ভেরিয়েবলটি) কোন টাইপের তা প্রদর্শন করে।

                    অপরদিকে, অবজেক্টের উপর মাউস রাখলে System.object দেখা যাবে। কিন্তু ভ্যারের উপর মাউস রাখলে System.string দেখা যায়। 
                    অর্থাৎ, ভ্যারের ভ্যালু পরিবর্তনের সঙ্গে সঙ্গে ভ্যারের উপর মাউস রাখলে এর টাইপ পরিবর্তিত হয়ে যায়।

                    C# এ, যখনই আপনি ভ্যারে কোনো ভ্যালু অ্যাসাইন করবেন, কম্পাইলার কম্পাইল টাইমেই সেই ভ্যালুর 
                    যে টাইপ হতে পারে (যেমন, Md Salim Hossain), সেই ভ্যালুটি কোন টাইপের (যেমন, string, int, double ইত্যাদি), 
                    সেই টাইপটি এখানে অ্যাসাইন করে দেয়।
             */

            // object a = 10;
            var yourName = "Md Salim Hossain";

            var yourAge = 20;          
            WriteLine( yourName +" , "+ yourAge);

            ReadLine();

        }
    }
}
