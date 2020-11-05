using System;
using System.Collections.Generic;
using System.Text;

namespace weapongame
{
    class Enemy
    {


        public static int enemyStat;

        public static void RollStat(int weaponMinStat, int weaponMaxStat)
        {
            Random rnd = new Random();
            enemyStat = rnd.Next(weaponMinStat, weaponMaxStat);

        }


        public static int skeletonStat;
        public static bool skeletonResult;
        public static string skeletonWinLose;

        public static void Skeleton()
        {
            Console.WriteLine();
            Enemy.RollStat(1, 10);
            skeletonStat = enemyStat;
        }

        public static int dragonStat;
        public static bool dragonResult;
        public static string dragonWinLose;
        public static void Dragon()
        {
            Console.WriteLine();
            Enemy.RollStat(4, 10);
            dragonStat = enemyStat;
        }


        public static int demogorgonStat;
        public static bool demogorgonResult;
        public static string demogorgonWinLose;
        public static void Demogorgon()
        {
            Console.WriteLine();
            Enemy.RollStat(1, 10);
            demogorgonStat = enemyStat;
        }



    }
}
