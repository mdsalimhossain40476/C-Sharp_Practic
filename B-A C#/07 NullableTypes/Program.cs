using System;
using static System.Console;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string হল রেফারেন্স টাইপ, তাই এর মান null হতে পারে। অন্যদিকে, string default ভাবে null মান নেয়।

             তবে int হল value টাইপ, তাই কোনো ভেরিয়েবলে মান না দিলেও ডিফল্টভাবে সি# এটিকে 0 দেয়।

            int এর ভেরিয়েবলকে ভ্যালু null হিসাবে প্রদর্শন করতে চাইলে টাইপের পরে একটি প্রশ্নবোধক চিহ্ন দিতে হবে (int?)।
             */
            int? firstName = 155; 
            int secondNumber;
            /*
            if (firstName == null)
            {
            secondNumber = 0;
            }
            else
            {
            secondNumber = (int) firstName;  // firstName যেহেতু nullable তাই c# compiler / রচয়িতা টাইমে assign(নির্ধারিত করা)  করার সময় এই সমস্যা দূর করার জন্য কাস্টিং {(int) firstName} করে বলে দিতে হবে।
            }
            */
            secondNumber = firstName ?? 0;//secondNumber = firstName null হয় তাহলে তুমি 0 দেখাও । Nullable বস্তুর একটি মান থাকতে হবে।

            WriteLine( secondNumber);

            ReadLine();

        }
    }
}
