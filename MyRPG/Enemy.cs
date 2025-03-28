using System;
using System.Net.NetworkInformation;

namespace MyRPG
{
    public class Enemy
    {
        private static int powerUpCollected;
        private string name;
        private float health;
        private float shield;

        static Enemy()
        {
            powerUpCollected = 0;
        }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string newName)
        {
            name = newName.Substring(0, Math.Min(8, newName.Length));
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health || powerUp == PowerUp.Shield)
            {
                if(health + value > 100)
                {
                    float actualValueToIncrease = Math.Min(value, 100 - GetHealth());
                    health += actualValueToIncrease;
                }
                else
                {
                    health += value;
                }
            }

            if (powerUp == PowerUp.Shield)
            {
                if (shield + value > 100)
                {
                    float actualValueToIncrease = Math.Min(value, 100 - GetShield());
                    shield += actualValueToIncrease;
                }
                else
                {
                    shield += value;
                }
            }

            powerUpCollected++;
        }

        public static int GetTotalPowerUpCount()
        {
            return powerUpCollected;
        }
    }
}