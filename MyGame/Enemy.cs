using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Construtor do enemy
        public Enemy(string name)
        {
            this.name=name;
            health=100;
            shield=0;
        }
    }
}