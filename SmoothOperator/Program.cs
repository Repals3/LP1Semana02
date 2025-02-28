using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string num;

            System.Console.WriteLine("Insere número inteiro: ");
            num = Console.ReadLine();

            sbyte conv = Convert.ToSByte(num);


            conv--;
            System.Console.WriteLine(conv);
            conv++;
            System.Console.WriteLine(conv);




        }
    }
}