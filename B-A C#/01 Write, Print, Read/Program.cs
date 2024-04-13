using System;
using static System.Console;

namespace _01WritePrintRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                C# এ মান আউটপুট করতে বা টেক্সট প্রিন্ট করতে, আপনি WriteLine() মেথড ব্যবহার করতে পারেন:
            
                আপনি যতগুলি চান ততগুলি WriteLine () পদ্ধতি যোগ করতে পারেন। লক্ষ্য করুন যে এটি প্রতিটি পদ্ধতির জন্য একটি নতুন লাইন যোগ করবে:
                
                আপনি সংখ্যাও পাঠাতে পারেন, এবং গাণিতিক গণনা করতে পারেন:

                এখানে একটি Write() পদ্ধতি রয়েছে, যা WriteLine()   - এর অনুরূপ।

                একমাত্র পার্থক্য হল এটি আউটপুটের শেষে একটি নতুন লাইন যুক্ত করে না।


            */
            WriteLine("Md Salim Hossain");

            //  using static System.Console; structure /গঠনপ্রণালী ব্যবহার করার কারণে Console ব্যবহার করা হচ্ছে না।
            ReadLine();
        }
    }
}
