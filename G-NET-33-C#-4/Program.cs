using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

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

            #region Q2

            /*
             Question 02: Ticket Pricing System  
                 Write a program for a cinema ticket pricing system with these rules: 
                 Condition Price 
                 Age < 5  Free 
                 Age 5 - 12 30 LE 
                 Age 13 - 59 50 LE 
                 Age 60+ 25 LE 
                 Weekend (Fri/Sat) 
                 Add 10 EGP to any non-free ticket 
                 Student with valid ID 20% discount (applied after weekend 
                 surcharge) 
                 Tasks: 
                 (a) Implement using if-else if-else statements 
                 (b) The program should ask for: age, day of week (1-7, where 
                 6=Fri, 7=Sat), and whether they have a student ID (yes/no) 
                 (c) Display the final price with a breakdown of how it was 
                 calculated
             */
            //=======Answer ===========
            //Console.WriteLine("Please Enter Age");
            //int age = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("number of day");
            //int day = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("Do you Have Student ID");
            //string input = Console.ReadLine()!;
            //bool haveStudentID = input.ToLower() == "yes";
            //double price;
            //if (age<5)
            //{
            //    Console.WriteLine("your price is Free");
            //}
            //else if (age>=5&& age<=12)
            //{
            //    price = 30;

            //    if (day==6||day==7)
            //    {
            //        price = price + 10;
            //    }

            //    if (haveStudentID)
            //    {
            //        price = price - (price *0.2);
            //    }
            //    Console.WriteLine($"Your price is : {price}");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    price = 50;

            //    if (day == 6 || day == 7)
            //    {
            //        price = price + 10;

            //    }
            //    if (haveStudentID )
            //    {
            //        price = price - (price * 0.2);
            //    }
            //    Console.WriteLine($"Your price is : {price}");
            //}
            //else if (age>=60)
            //{
            //    price = 25;

            //    if (day == 6 || day == 7)
            //    {
            //        price = price + 10;
            //    }
            //    Console.WriteLine($"Your price is : {price}");

            //}

            #endregion

            #region Q3 
            #region  Traditional switch
            //Console.WriteLine("Please Enter File Extension");
            //string fileExtension = Console.ReadLine()!;
            //string fileType;
            //switch (fileExtension.ToLower())
            //{
            //    case ".pdf":
            //        fileType = "Pdf Document";
            //        break;
            //    case ".docx":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //        fileType = "Excel SpreadSheet ";
            //        break;
            //    case ".jpg":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown file";
            //        break;   


            //}
            //Console.WriteLine(fileType);
            #endregion
            #endregion

            #region Q4
            //Console.WriteLine("Please Enter Temprature");
            //int temp =int.Parse(Console.ReadLine()!);
            //string WeatherAdvice = temp < 0 ? "Freezing! Stay indoors." : temp < 15 ? "Cold. Wear a jacket." : temp < 25 ? "Pleasant weather" : temp < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";
            //Console.WriteLine(WeatherAdvice);

            // this not readle and prefere to use if/else if 
            #endregion

            #region Q5


            //string password;
            //int attempts = 0;
            //bool isValid = true;


            //do
            //{
            //    Console.WriteLine("Enter Valid Password ");
            //    password = Console.ReadLine()!;

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("● Minimum 8 characters ");
            //        isValid = false;
            //    }
            //    if (!password.Any(char.IsUpper))
            //    {
            //        isValid = false;
            //        Console.WriteLine("● At least one uppercase letter  ");
            //    }
            //    if (!password.Any(char.IsDigit))
            //    {
            //        isValid = false;
            //        Console.WriteLine("At least one digit ");
            //    }
            //    if (password.Any(char.IsWhiteSpace))

            //    {
            //        isValid = false;
            //        Console.WriteLine("No spaces allowed ");

            //    }
            //    if (isValid)
            //    {
            //        Console.WriteLine("Password Accepted");
            //    }

            //    attempts++;
                
            //}
            //while (attempts <= 5);
            //if (attempts > 5)

            //{
            //    Console.WriteLine("===========================");
            //    Console.WriteLine("Account Locked !");
            //}


            #endregion




        }
    }
}
