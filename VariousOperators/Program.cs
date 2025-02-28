using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Insere número inteiro-não negativo:");
            string InputUser;

            InputUser = Console.ReadLine();

            byte x = Convert.ToByte(InputUser);

            System.Console.WriteLine(x/2);
            System.Console.WriteLine(x << 3);
            System.Console.WriteLine(x ^ 6);
            System.Console.WriteLine((x > 10)? true:false);

        }
    }
}