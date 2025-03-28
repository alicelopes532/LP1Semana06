using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MyRPG;

namespace GameLevel 
{
    public class GameLevel
    {
        GameLevel gl1 = new GameLevel.gl1();
        GameLevel gl2 = new GameLevel.gl2();

        Enemy.SetEnemyInRoom()
            {
            SetEnemyInRoomEnemy(1, new Enemy("Worf"));
            SetEnemyInRoom(7, new Enemy("Picard"));
            SetEnemyInRoom(16, new Enemy("Data"));
            SetEnemyInRoom(94, new Enemy("Riker"));
            SetEnemyInRoom(59, new Enemy("Troi"));
            }

        foreach(Hardness level in levels)
            {
                Console.WriteLine($"{level.GetHardness()} {level.GetRoomNumber()} {level.GetEnemiesNumber()}");
            }
        PrintEnemies()
        {
            Console.ReadLine($"1, new Enemy("Worf")");
            Console.ReadLine($"7, new Enemy("Picard")");
            Console.ReadLine($"16, new Enemy("Data")");
            Console.ReadLine($"94, new Enemy("Riker")");
            Console.ReadLine($"59, new Enemy("Troi")");
        }
    }
}