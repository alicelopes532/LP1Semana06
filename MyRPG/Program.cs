using System;

namespace MyRPG
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for(int i = 0; i < enemies.Length; i++)
            {
                Console.Write($"Enemy name {i + 1}: ");
                enemies[i] = new Enemy(Console.ReadLine());
            }

            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }

            enemies[0].PickupPowerUp(PowerUp.Shield, 40f);

            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");

            enemies[0].TakeDamage(50f);

            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");

            enemies[0].PickupPowerUp(PowerUp.Health, 50f);

            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");

            Console.WriteLine(Enemy.GetTotalPowerUpCount());


        }
    }
}