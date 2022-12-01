using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        public enum Calc
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }
        struct varStruct
        {
            public int Choice;
            public Calc Choice1;
            public int FirstNum;
            public int SecondNum;
            public int ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many calculation you want to do?");
            int n = int.Parse(Console.ReadLine());
            List<varStruct> calculations = new List<varStruct>();
            Console.WriteLine("\n\n");
            
            for(int i = 0; i<n; i++)
            {
                varStruct structOb = new varStruct();
                Console.WriteLine("Enter 1st number");
                structOb.FirstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                structOb.SecondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose one:\nAddition: 0\nSubtraction: 1\nMultiplication: 2\nDivision: 3");
                structOb.Choice = int.Parse(Console.ReadLine());

                structOb.Choice1 = (Calc)structOb.Choice;

                switch (structOb.Choice1)
                {
                    case Calc.Addition:
                        structOb.ans = structOb.FirstNum + structOb.SecondNum;
                        calculations.Add(structOb);
                        break;
                    case Calc.Subtraction:
                        structOb.ans = structOb.FirstNum - structOb.SecondNum;
                        calculations.Add(structOb);
                        break;
                    case Calc.Multiplication:
                        structOb.ans = structOb.FirstNum * structOb.SecondNum;
                        calculations.Add(structOb);
                        break;
                    case Calc.Division:
                        structOb.ans = structOb.FirstNum / structOb.SecondNum;
                        calculations.Add(structOb);
                        break;
                    default:
                        Console.WriteLine("Please enter the correct choice!");
                        n = n + 1;
                        break;
                }
               
                Console.WriteLine("\n\n");
            }


            Console.WriteLine("Which number answer do you want: ");
            int num = int.Parse(Console.ReadLine());
            if(num > calculations.Count)
            {
                Console.WriteLine("Please enter the correct position!");
            }
            else
            {
                Console.WriteLine($"Ans {num} is: {calculations[num - 1].ans}");
            }
            

        }
    }
}
