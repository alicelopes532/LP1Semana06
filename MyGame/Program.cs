using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private int health;
        private int shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        public static void Main()
        {
        }

          public string GetName()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= (int)damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= (int)damageStillToInflict;
                if (health < 0) health = 0;
            }
            
        }
    }
}