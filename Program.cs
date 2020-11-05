using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace weapongame
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Weapon.WeaponSelection();
            AnyKeyClear();

            Weapon.RollStat(1, 10);
            AnyKeyClear();

            Weapon.NameYourWeapon();
            AnyKeyClear();

            //Console.WriteLine("Your " + Weapon.yourWeapon + ", " + Weapon.weaponName + ", deals " + Weapon.stat + " in damage.");

            Console.WriteLine("Your {0}, {1}, deals {2} in damage.", Weapon.yourWeapon, Weapon.weaponName, Weapon.stat);
            Console.WriteLine();

            if (Weapon.stat <= 4)
            {
                Console.WriteLine("Well, that damage is unfortunate... May the odds be in your favor.");
            }
            else if (Weapon.stat == 10)
            {
                Console.WriteLine("Wow, that's a great damage stat, you should have no issues!");
            }
            else
            {
                Console.WriteLine("Eh, not too bad, but I've seen better damage.");
            }




            
            AnyKeyClear();
            //Skeleton enemy
            Enemy.Skeleton();
            Console.WriteLine("A skeleton appears in front of you! It has " + Enemy.skeletonStat + " hit points. You attack with " + Weapon.yourWeapon);
            Console.WriteLine();


            if(Weapon.stat>Enemy.skeletonStat)
            {
                //You destroy the enemy
                Console.WriteLine("Your attack destroys the skeleton instantly.");
                Enemy.skeletonResult = true;
            }
            else if(Weapon.stat == Enemy.skeletonStat)
            {
                //It's a draw
                Console.WriteLine("Your attack bounces off the skeleton's head and it slaps you across the face.");
                Enemy.skeletonResult = false;
            }
            else
            {
                //You lose
                Console.WriteLine("The is unphased and it uppercuts you across the chin, you do a backflip as you crash into the ground.");
                Enemy.skeletonResult = false;
            }





            AnyKeyClear();
            //Dragon enemy
            Enemy.Dragon();
            Console.WriteLine("OH SHIT! A hulking dragon appears in front of you! It has " + Enemy.dragonStat + " hit points. You attack with " + Weapon.yourWeapon);
            Console.WriteLine();

            if (Weapon.stat > Enemy.dragonStat)
            {
                //You destroy the enemy
                Console.WriteLine("Your heart is true, your attack obliterates the dragon, it's blood sprays all over the ground.");
                Enemy.dragonResult = true;
            }
            else if (Weapon.stat == Enemy.dragonStat)
            {
                //It's a draw
                Console.WriteLine("Your attack is true, but not strong enough to kill the dragon. It slaps you with its tail, splattering you into the wall.");
                Enemy.dragonResult = false;
            }
            else
            {
                //You lose
                Console.WriteLine("The dragon roars in laughter, causing it to breathe fire that douses you in flames. You burn to a crisp.");
                Enemy.dragonResult = false;
            }



            AnyKeyClear();
            //Demogorgon enemy
            Enemy.Demogorgon();
            Console.WriteLine("You hear a strange sound, a demogorgon appears in front of you! It has " + Enemy.demogorgonStat + " hit points. You attack with " + Weapon.yourWeapon);
            Console.WriteLine();

            if (Weapon.stat > Enemy.demogorgonStat)
            {
                //You destroy the enemy
                Console.WriteLine("Luckily, you don't need to be in the Upside Down to soak the walls with the Demogorgon's blood.");
                Enemy.demogorgonResult = true;
            }
            else if (Weapon.stat == Enemy.demogorgonStat)
            {
                //It's a draw
                Console.WriteLine("The Demogorgon is hurt, but not enough to kill it. It pounces on you and coccoons you in a pod, placing a slug in your mouth.");
                Enemy.demogorgonResult = false;
            }
            else
            {
                //You lose
                Console.WriteLine("The Demogorgon tilts his head..... and then bites your head off.");
                Enemy.demogorgonResult = false;
            }



            //set if you failed or succeeded aginst skeleton
            if (!Enemy.skeletonResult)
            {
                Enemy.skeletonWinLose = "failed";
            }
            else
            {
                Enemy.skeletonWinLose = "succeeded";
            }

            //set if you failed or succeeded aginst dragon
            if (!Enemy.dragonResult)
            {
                Enemy.dragonWinLose = "failed";
            }
            else
            {
                Enemy.dragonWinLose = "succeeded";
            }

            //set if you failed or succeeded aginst demogorgon
            if (!Enemy.demogorgonResult)
            {
                Enemy.demogorgonWinLose = "failed";
            }
            else
            {
                Enemy.demogorgonWinLose = "succeeded";
            }



            //After Action Report
            AnyKeyClear();
            Console.WriteLine("Ater Action Report:");
            Console.WriteLine("Your weapon of choice was: " + Weapon.yourWeapon);
            Console.WriteLine("For some reason you named it: " + Weapon.weaponName);
            Console.WriteLine(Weapon.weaponName + " hits for " + Weapon.stat);
            Console.WriteLine("You " + Enemy.skeletonWinLose + " to kill the skeleton");
            Console.WriteLine("You " + Enemy.dragonWinLose + " to kill the dragon");
            Console.WriteLine("You " + Enemy.demogorgonWinLose + " to kill the demogorgon");


            AnyKeyClear();
            // closes the program
            Environment.Exit(0);





            // End Main Program
        }


        // This section defines the "press any key to continue" message. One will clear the screen and the other will not.
        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        public static void AnyKeyClear()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }


        
    }

}
