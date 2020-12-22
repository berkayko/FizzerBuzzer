using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Range\n" +
                "e.g:1-20");
            string x = string.Empty;
            String[] inputArr;
            int start, end;
            StringBuilder sb=new StringBuilder();
            Fizzer fz = new Fizzer();
            do
            {
                x = Console.ReadLine();
                inputArr = x.Split("-",StringSplitOptions.RemoveEmptyEntries);
                //state 1
                if (inputArr.Length == 2)
                {
                    start = Convert.ToInt32( inputArr[0]);
                    end = Convert.ToInt32(inputArr[1]);
                    for(int i = start; i <= end; i++)
                    {
                        if(string.IsNullOrEmpty(sb.ToString()))
                            sb.Append(fz.DefineNumber(i, false));
                        else
                            sb.Append(", " + fz.DefineNumber(i, false));

                    }
                    Console.WriteLine("State 1 \n" +
                        "{0}", sb.ToString());
                    //state 2
                    sb = new StringBuilder();
                    for (int i = start; i <= end; i++)
                    {
                        if (string.IsNullOrEmpty(sb.ToString()))
                            sb.Append(fz.DefineNumber(i, true));
                        else
                            sb.Append(", " + fz.DefineNumber(i, true));
                    }
                    Console.WriteLine("State 2 \n" +
                        "{0}", sb.ToString());
                    //state 3
                    sb = new StringBuilder();
                    fz.fizzCount = 0;
                    fz.buzzCount = 0;
                    fz.fizzBuzzCount = 0;
                    fz.luckCount = 0;
                    fz.numberCount = 0;
                    for (int i = start; i <= end; i++)
                    {
                        if (string.IsNullOrEmpty(sb.ToString()))
                            sb.Append(fz.DefineNumber(i, true));
                        else
                            sb.Append(", " + fz.DefineNumber(i, true));
                    }
                    sb.AppendLine("\nFizz: "+fz.fizzCount+"\n" +
                        "Buzz: "+fz.buzzCount+"\n" +
                        "FizzBuzz: "+fz.fizzBuzzCount+"\n" +
                        "Luck: " +fz.luckCount+"\n"+
                        "Number: "+ fz.numberCount);
                    Console.WriteLine("State 3 \n" +
                        "{0}", sb.ToString());
                }
                else
                {
                    Console.WriteLine("Enter Range\n" +
                                            "e.g:1-20");
                }

            }
            while (x != "0");

        }

        //public static string DefineNumber(int number,bool checkLuck)
        //{
        //    string result ;
        //    if (checkLuck && number.ToString().Contains('3'))
        //    {
        //        result= "Luck";
        //        luckCount += 1;
        //    }
        //    else if (number % 3 == 0 && number % 5 == 0)
        //    {
        //        result = "FizzBuzz";
        //        fizzBuzzCount += 1;
        //    }
        //    else if (number % 3 == 0)
        //    {
        //        result = "Fizz";
        //        fizzCount += 1;
        //    }
        //    else if (number % 5 == 0)
        //    {
        //        result = "Buzz";
        //        buzzCount += 1;
        //    }
        //    else { 
        //        result = number.ToString();
        //        numberCount += 1;
        //    }
                
        //    return result;

        //}

    }


    public class Fizzer
    {
        public  int fizzCount, buzzCount, fizzBuzzCount, luckCount, numberCount;
        public string DefineNumber(int number, bool checkLuck)
        {
            string result;
            if (checkLuck && number.ToString().Contains('3'))
            {
                result = "Luck";
                luckCount += 1;
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
                fizzBuzzCount += 1;
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
                fizzCount += 1;
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
                buzzCount += 1;
            }
            else
            {
                result = number.ToString();
                numberCount += 1;
            }

            return result;
        }
    }
}
