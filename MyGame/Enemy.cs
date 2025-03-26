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
            SetName(name);
            health = 100;
            shield = 0;
        }

        //devolve o name
        public string GetName()
        {
            return name;
        }

        // dá damage ao enemy
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        //devolve a health
        public float GetHealth()
        {
            return health;
        }

        //devolve o shield
        public float GetShield()
        {
            return shield;
        }

        public void SetName(string NewName)
        {
            if(NewName.Length>8)
            {
                name=NewName.Substring(0,8);
            }
            else
            {
                name=NewName;
            }
        }



    }
}