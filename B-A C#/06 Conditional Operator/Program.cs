using System;
using static System.Console;


namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 C# Comparison Operators
                 Comparison operators দুটি মান (বা ভেরিয়েবল) তুলনা করতে ব্যবহৃত হয়। 
                 এটি প্রোগ্রামিংয়ে গুরুত্বপূর্ণ, কারণ এটি আমাদের উত্তর খুঁজে পেতে এবং সিদ্ধান্ত নিতে সাহায্য করে।

                 একটি Comparison রিটার্ন মান হল True বা False। এই মানগুলিকে বুলিয়ান মান 
                 হিসাবে পরিচিত করা হয় এবং বুলিয়ান এবং If..Else অধ্যায়ে আপনি এগুলি সম্পর্কে আরও জানতে পারবেন।

                C# Logical Operators
                Comparison অপারেটরের মতোই, আপনি Logical অপারেটরের সাহায্যেও সত্য বা মিথ্যা মানের জন্য পরীক্ষা করতে পারেন।
               
                লজিক্যাল অপারেটরগুলি চলক বা মানগুলির মধ্যে লজিক নির্ধারণ করতে ব্যবহৃত হয়:

             */
            // if স্টেটমেন্ট সব সময় সত্য রিটার্ন করে
            int number = 15;
            //  Equal to Operator
            if (number == 15)  //  number থেকে 15 সমান অর্থাৎ ঘটনা সত্য তাই এখানে 1 Number Equal 15 প্রিন্ট করে দেখাচ্ছে
            {
                WriteLine("1 Number Equal 15");
            }  //  Outputs:    1 Number Equal 15

            WriteLine("================ \n");

            //  Not equal Operator
            if (number != 20) //  number থেকে ২০ সমান নয় অর্থাৎ ১৫ থেকে ২০ বড় অর্থাৎ ঘটনা সত্য তাই এখানে 2 Number Equal 15 প্রিন্ট করে দেখাচ্ছে
            {
                WriteLine("2 Number Equal 15");
            }       //  Outputs:    2 Number Equal 15
            WriteLine("================ \n");

            //  Greater than Operator
            if (number > 12) //      number  থেকে 12 ছোট  অর্থাৎ 12 থেকে 15 বড় অর্থাৎ ঘটনা সত্য তাই এখানে 3 Number Equal 15 প্রিন্ট করে দেখাচ্ছে
            {
                WriteLine("3 Number equal 15");
            }   //  Outputs:    3 Number Equal 15
            WriteLine("================ \n");


            //  Less than Operator
            if (number < 20)   //      number  থেকে 20 বড়  অর্থাৎ 15 থেকে 20 বড় অর্থাৎ ঘটনা সত্য  তাই এখানে 4 Number Equal 15 প্রিন্ট করে দেখাচ্ছে
            {
                WriteLine("4 Number equal 15");
            }//  Outputs:    4 Number Equal 15
            WriteLine("================ \n");

             //  Greater than or equal to
            if (number>= 12)
            {
                WriteLine("5 Number equal 15");
            }  //  Outputs:    5 Number Equal 15
            WriteLine("================ \n");


            //  Less than or equal to
            if (number <= 20) 
            {
                WriteLine("6 Number equal 15");
            }
            WriteLine("================ \n");
            

            
            //C# Logical Operators
            // Comparison অপারেটরের মতোই, আপনি Logical অপারেটরের সাহায্যেও সত্য বা মিথ্যা মানের জন্য পরীক্ষা করতে পারেন।
            // && / (Logical and ) যদি উভয় বিবৃতি সত্য হয় তাহলে True রিটার্ন
            if (number > 12 && number < 20) // যেহেতু উভয় বিবৃতি সত্য তাই Returns True if both statements are true রিটার্ন করে
            {
                WriteLine("Returns True if both statements are true");
            }
            WriteLine("======================================== \n");

            // ||/Logical or	যদি একটি স্টেটমেন্ট সত্য হয় তবে True রিটার্ন করে।
            if (number  > 18 || number < 20)
            {
                WriteLine("Returns True if one of the statements is true");
            }//  যেহেতু একটি বিবৃতি সত্য তাই Returns True if one of the statements is true রিটার্ন করে
            WriteLine("============================================== \n");

            //      ! / Logical not	    ফলাফলটিকে উল্টানো, যদি ফলাফলটি True হয় তবে False ফিরিয়ে দেয়।
            if(!(number < 18 && number>20))
            {
                WriteLine("Reverse the result, returns False if the result is true");
            } //  যেহেতু উভয় বিবৃতি False তাই Reverse the result, returns False if the result is true রিটার্ন করে
                        /*
                            C# Short Hand If...Else
                            Short Hand If...Else (Ternary Operator)
                            একটি সংক্ষেপ আছে, যা টারনারি অপারেটর হিসেবে পরিচিত কারণ এটি তিনটি অপারেন্ডে গঠিত। এটি একাধিক লাইনের কোডকে একটি লাইনে 
                            প্রতিস্থাপন করতে ব্যবহার করা যেতে পারে। এটি প্রায়ই সহজ If...Else স্টেটমেন্ট প্রতিস্থাপন করতে ব্যবহার করা হয়
                            variable = (condition) ? expressionTrue :  expressionFalse;
                        */
                        // লেখার পরিবর্তে।
                         int time = 20;
                          if (time < 18) 
                          {
                            Console.WriteLine ("Good day.");
                          } 
                          else 
                          {
                            Console.WriteLine ("Good evening.");  //  Output : Good evening.
                          }
                          // আপনি সহজেই লিখতে পারেন।
                          int time = 20;
                          string result = (time < 18) ? "Good day." : "Good evening.";
                          Console.WriteLine (result);   //  Output : Good evening.
                bool isTrue = true;
                WriteLine(isTrue ? "MD SALIM HOSSAIN" : "MST SALINA BEGUM");
                WriteLine("======================================== \n");
                
                bool isFalse = false;
                WriteLine(isFalse ? "MD SALIM HOSSAIN" : "MST SALINA BEGUM");
            ReadLine();
        }
    }
}
