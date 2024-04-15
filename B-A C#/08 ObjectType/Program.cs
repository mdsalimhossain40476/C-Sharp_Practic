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
                    object type  তখনই  ব্যবহার করব আমরা যখন জানব না এর মধ্যে কোন ধরনের ভেলু আসবে। 
                    object ভেরিবল ডিক্লেয়ার করে তারমধ্যে ভ্যালুটা রেখে দেব ইউজার যখন ইউজ করবে বা সেটা নিয়ে
                    কাজ করতে যাবে তার প্রয়োজনে কনভার্ট করে তার মত করে ব্যবহার করবে। 
                    
                    object কে যদি কোন ম্যাথমেটিক্যাল অপারেশন চালাতে হয় তাহলে অবশ্যই তার টাইপ 
                    উল্লেখ করে দিতে হবে কাস্ট করে। কনকেটিনিশন দুইটি ভ্যারিয়েবল কে জোড়া দিতে সাহায্য করে।
                    যদি কোনো অবজেক্টের মধ্যে কোনো গাণিতিক/mathematical অপারেশন চালাতে চাওয়া হয়, তাহলে Explicit Casting (ম্যানুয়ালি) করে অপারেশনটি সম্পন্ন করতে হবে।
                    
                    কাস্টিং করার নিয়ম : ভেরিয়েবল এর শুরুতে (type) প্রথম ব্রাকেটের মধ্যে এর টাইপ বসাবো যেমন (int) integer । কম্পাইল এখন বুঝতে পারছে এটা একটা integer। 
                                
                    যদি  object type  হয়  কোন ধরনের সিম্পল Arithmetic অপারেশন চালানো যাবে না এটা হচ্ছে সীমাবদ্ধতা object এর জন্য
                    object এর মধ্যে যেকোনো ধরনের ভেলু এসাইন করা সম্ভব            
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
            WriteLine(shortNumber);//-32768 থেকে 32767 ভেরিয়েবল তার ভ্যালু নিতে পারে নিতে পারে।
                        
            ushort uShortNumber = 32767 * 2;
            WriteLine( uShortNumber);
            /*
                 ushort Variable short ভ্যারিবল থেকে দ্বিগুণ ভ্যালু বহন করতে পারে। 
                 ushort কখনো – (মাইনাস)  চিহ্ন বহন করতে পারে না |  আমরা নিশ্চিত যে, 
                কখনোই – (মাইনাস) চিহ্ন সংযুক্ত ভ্যালু ব্যবহার করব না তখনই শুধু ushort ব্যবহার করব| 
                short এর ডাবল ভ্যালু বহন করতে পারে ushort
                32767*2 = 65534
                       
            */
            
            ReadLine();


           
        }
    }
}
