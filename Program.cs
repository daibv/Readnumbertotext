using System;
using System.Collections;

namespace Readnumbertotext
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n;
            int ones;
            int tens;
            int hundreds;

            Console.WriteLine("Enter a number in range of (0-999) and output shall be that number in string:");
            
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(" The number you have entered in string is:");

            if (n<10)
            {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
            Console.ReadKey();
            }
            else if (n<20)
            {
                ones = (int)n%10;
            
                switch (ones)
            {
                case 0:
                    Console.WriteLine("Ten");
                    break;
                case 1:
                    Console.WriteLine("Eleven");
                    break;
                case 2:
                    Console.WriteLine("Twelve");
                    break;
                case 3:
                    Console.WriteLine("Thirteen");
                    break;
                case 4:
                    Console.WriteLine("Forteen");
                    break;
                case 5:
                    Console.WriteLine("Fifteen");
                    break;
                case 6:
                    Console.WriteLine("Sixteen");
                    break;
                case 7:
                    Console.WriteLine("Seventeen");
                    break;
                case 8:
                    Console.WriteLine("Eighteen");
                    break;
                case 9:
                    Console.WriteLine("Nineteen");
                    break;
            }
                Console.ReadKey();
            }
            else if (n<100)
            {
                tens = (int)n/10;
                ones = (int)n%10;
                switch (tens)
                {
                case 2:
                    Console.Write("Twenty");
                    break;
                case 3:
                    Console.Write("Thirty");
                    break;
                case 4:
                    Console.Write("Forty");
                    break;
                case 5:
                    Console.Write("Fifty");
                    break;
                case 6:
                    Console.Write("Sixty");
                    break;
                case 7:
                    Console.Write("Seventy");
                    break;
                case 8:
                    Console.Write("Eighty");
                    break;
                case 9:
                    Console.Write("Ninety");
                    break;
                }
                switch (ones)
                {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                }
            }
            else if (n<110)
            {
                int tensANDones = (int)n%100;
                ones=(int)tensANDones%10;
                switch(ones)
                {
                    case 0:
                        Console.Write("One hundred");
                        break;
                    case 1:
                        Console.Write("One hundred and One");
                        break;
                    case 2:
                        Console.Write("One hundred and Two");
                        break;
                    case 3:
                        Console.Write("One hundred and Three");
                        break;
                    case 4:
                        Console.Write("One hundred and Four");
                        break;
                    case 5:
                        Console.Write("One hundred and Five");
                        break;
                    case 6:
                        Console.Write("One hundred and Six");
                        break;
                    case 7:
                        Console.Write("One hundred and Seven");
                        break;
                    case 8:
                        Console.Write("One hundreds and Eight");
                        break;
                    case 9:
                        Console.Write("One hundred and Nine");
                        break;
                }
            }
            else if (n<120)
            {
                ones=(int)n%10;
                switch(ones)
                {
                    case 0:
                        Console.Write("One hundred and ten");
                        break;
                    case 1:
                        Console.Write("One hundred and eleven");
                        break;
                    case 2:
                        Console.Write("One hundred and twelve");
                        break;
                    case 3:
                        Console.Write("One hundred and thirteen");
                        break;
                    case 4:
                        Console.Write("one hundred and fourteen");
                        break;
                    case 5:
                        Console.Write("One hundred and fifteen");
                        break;
                    case 6:
                        Console.Write("one hundred and sixteen");
                        break;
                    case 7:
                        Console.Write("one hundred and seventeen");
                        break;
                    case 8:
                        Console.Write("One hundred and eighteen");
                        break;
                    case 9:
                        Console.Write("One hundred and nineteen");
                        break;
                        
                }
            }
            else if (n<1000)
            {
                hundreds = (int)n/100;
                int tens1 = (int)n%100;
                tens = (int)tens1/10;
                ones=(int)n%10;
                switch(hundreds)
                {
                    case 1:
                        Console.Write("One hundred");
                        break;
                    case 2:
                        Console.Write("Two hundreds");
                        break;
                    case 3:
                        Console.Write("Three hundred");
                        break;
                    case 4:
                        Console.Write("Four hundred");
                        break;
                    case 5:
                        Console.Write("Five hundred");
                        break;
                    case 6:
                        Console.Write("Six hundred");
                        break;
                    case 7:
                        Console.Write("Seven hundred");
                        break;
                    case 8:
                        Console.Write("Eight hundred");
                        break;
                    case 9:
                        Console.Write("Nine hundred");
                        break;
                }
                switch(tens)
                {
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("Thirty");
                        break;
                    case 4:
                        Console.Write("Forty");
                        break;
                    case 5:
                        Console.Write("Fifty");
                        break;
                    case 6:
                        Console.Write("Sixty");
                        break;
                    case 7:
                        Console.Write("Seventy");
                        break;
                    case 8:
                        Console.Write("Eighty");
                        break;
                    case 9:
                        Console.Write("Ninety");
                        break;
                }
                switch(ones)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Sixn");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                }
            }
            
            if (n>=1000)
            {
                Console.WriteLine("Your number is out of my ability to read in string");
            }
        }
    }
}


