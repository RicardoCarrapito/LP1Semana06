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
            

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(dice.Next(1,6));
                
            }


        }
    }
}
