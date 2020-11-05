using System;
using System.Collections.Generic;
using System.Text;

namespace weapongame
{
    class Weapon
    {

        public static string yourWeapon;

        public static void WeaponSelection()
        {
            string chooseWeapon;
            Console.WriteLine("First, you must choose your weapon!");
            Console.WriteLine();
            Console.WriteLine("1) Axe");
            Console.WriteLine("2) Sword");
            Console.WriteLine("3) Bow and Arrow");
            Console.WriteLine();
            chooseWeapon = Console.ReadLine().ToLower();
            switch (chooseWeapon)
            {
                case "1":
                case "1)":
                case "axe":
                    {
                        //Takes you to the axe function and rolls a stat for it.
                        yourWeapon = "battle axe";
                        Console.WriteLine("So, it looks like you chose the " + Weapon.yourWeapon + ". That's an interesting choice...");
                        break;
                    }
                case "2":
                case "2)":
                case "Sword":
                    {
                        //Takes you to the sword function and rolls a stat for it.
                        yourWeapon = "sword";
                        Console.WriteLine("So, it looks like you chose the " + Weapon.yourWeapon + ". That's an interesting choice...");
                        break;
                    }
                case "3":
                case "3)":
                case "bow":
                case "arrow":
                case "bow and arrow":
                    {
                        //Takes you to the bow and arrow function and rolls a stat for it.
                        yourWeapon = "bow and arrow";
                        Console.WriteLine("So, it looks like you chose the " + Weapon.yourWeapon + ". That's an interesting choice...");
                        break;
                    }
                default:
                    {
                        //set a default action if you fuck this up. 
                        Console.WriteLine("Do you have a deathwish? Choose a weapon....");
                        WeaponSelection();
                        Program.AnyKeyClear();
                        break;
                    }

            }
            //End of the Weapon Selection Part
        }


        public static int stat;


        public static void RollStat(int weaponMinStat, int weaponMaxStat)
        {
            Random rnd = new Random();
            stat = rnd.Next(weaponMinStat, weaponMaxStat);
            //Program.AnyKeyClear();
            Console.WriteLine("Your " + Weapon.yourWeapon + " will deal " + Weapon.stat + " in damage.");
            //return (stat);
        }

        public static string weaponName;

        public static void NameYourWeapon ()
        {
            Console.WriteLine("Type in the name of your " + Weapon.yourWeapon + " below.");
            weaponName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your " + Weapon.yourWeapon + " is now named " + Weapon.weaponName + "!");
            //return(weaponName);
        }








            // End Class
        }
}
