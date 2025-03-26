using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n=int.Parse(args[0]);
            
            Enemy[] inimigos= new Enemy[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Nome do inimigo{i+1}:");
                string nome=Console.ReadLine();
                inimigos[i]=new Enemy(nome);
            }

            foreach(Enemy i in inimigos)
            {
                Console.WriteLine($"{i.GetName()} {i.GetHealth()} {i.GetShield()}");
            }

        }
    }
}
