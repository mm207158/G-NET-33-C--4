using System.Diagnostics;
using System.Text;

namespace G_NET_33_C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Question 01 : A junior developer wrote this code to build a comma
                separated list of 5,000 product IDs: 
                 
                Tasks: 
                (a) Explain why this code is inefficient. Reference what happens in 
                memory. 
                (b) Rewrite this code using StringBuilder to be more efficient. 
                (c) Add timing code (using Stopwatch) to both versions and report 
                the time difference.
             */

            //=========Answer =====

            // (a) this code is inefficient becuase it creates 5000 object of Product ID in memory 

            // (b)
            // code with string 
            //var watch01 = new Stopwatch();
            //watch01.Start();    
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //watch01.Stop();

            //// code with StringBuilder
            //// 
            //var watch02 = new Stopwatch();
            //watch02.Start();
            //var sb =new StringBuilder();    
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append($"PROD- {i} ,");
            //}
            //watch02.Stop();

            //Console.WriteLine($"time of String  :{watch01.ElapsedMilliseconds}");//61 ms 
            //Console.WriteLine($"time of StringBuider :{watch02.ElapsedMilliseconds}");//7 ms


            #endregion
        }
    }
}
