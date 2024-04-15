using System;
using static System.Console;

namespace Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            dynamic number1 = 100;
            dynamic number2 = 30;
            
            WriteLine(number1 + number2);   //  Outputs :      130
            WriteLine(number1 - number2);   //  Outputs :      70
            WriteLine(number1 * number2);   //  Outputs :      3000
            WriteLine(number1 / number2);   //  Outputs :      3   //   কোনও মান double বা float এর মতো আসেনি। অর্থাৎ দশমিকের পরে কোনও সংখ্যা আসেনি(3.333333333333333)।
            WriteLine(number1 % number2);   //  Outputs :      10

            dynamic number = "Salim";
            dynamic numberOne= 30;
           
            WriteLine(number +" , "+ numberOne);
            WriteLine(number + numberOne);
            /*
              ডায়নামিক তখন ব্যবহার করব, যখন জানব এর টাইপ আসলে কী জিনিস? 
              কারণ সেটা যদি না জেনে আমি আমার মত করে কোড করে চলে গেলাম কম্পাইলার 
              কোন error দেয়নি আমার প্রোগ্রাম যখন বিল্ড করবো, বিল্ড এ কোন error নেই, 
              বিল্ড সফল কিন্তু যখন আমি রান করবো, রান টাইমে গিয়ে আমার প্রোগ্রাম স্টপ হয়ে যাবে।
              তাই এটা আসলে সব সময় ব্যবহার করা যাবে না। এটা যখন তখন পরিবর্তন হয়ে যায়।
           */
            WriteLine(number/numberOne);

            



            ReadLine();


        }
    }
}
