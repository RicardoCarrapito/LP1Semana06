using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n =int.Parse(args[0]);
            int s=int.Parse(args[1]);

            Random dice=new Random(s);
            int soma=0;

            for(int i=0;i<n;i++)
            {
                int valor=dice.Next(1,6);
                soma+=valor;
                
            }

            Console.WriteLine(soma);

        }
    }
}
