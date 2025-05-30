using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Data Types in c#
            Int: 4 Bytes
            long:8 Bytes 
            float:4 Byte
            double:8 Byte
            Char:1 Byte
            String:per character 2 bytes , eg: gupta , means 5 characters of each 2 bytes ,10 bytes total
            1 byte = 8 bit
             */

            /* int a = 38;
             float b = 34.32341234f;
             double c = 3343.2222135132513d;
             bool isGreat = false;
             char d= 'a';
             string e = "This is String";*/
            /*Console.WriteLine("Hello Buddy 1");
            Console.WriteLine("Hello Buddy 2");
            Console.WriteLine("I Love c#");
            Console.WriteLine("isGreat" + isGreat);*/


            //TypeCasting

            //There are Two Types of Casting

            //1: Implicit Casting
            //char to int to long to float to double

            //2: Explicit Casting
            //int x = (int)3.5;
            /* int x = 3;
             double y = x;
             long c = 2434;
             int z = 222;
             int e =(int)c;
             char h = (char)z;
             Console.WriteLine(h + "  This is h value");*/
            /* Console.WriteLine("Enter the Name");
             string name = Console.ReadLine();
             Console.WriteLine("Hey ths is ur name"+name);

             Console.WriteLine("How manu candies do you want");
             string can= Console.ReadLine();
             Console.WriteLine("You will get 4 more candies as bonus  " + (Convert.ToInt16(can) + 4.1222));
             */


            //################################
            /* Operators in c#
             1.Arithmetic Operators 
            2: Assignment Operatoes 
            3: Logical Operators
            4: Comparison Operators
             


            //Arithmetic Operators Examples
            int a = 3;
            int b = 4;
            Console.WriteLine(" the value of a + b  " + (a + b));
            Console.WriteLine(" the value of a - b  " + (a + b));
            Console.WriteLine(" the value of a * b  " + (a + b));
            Console.WriteLine(" the value of a / b  " + (a + b));
            Console.WriteLine(" the value of a % b  " + (a + b));



            // Assignment Operators Examples
            Console.WriteLine(" the value of a+=b" + (a += b));
            Console.WriteLine(" the value of a-=b" + (a -= b));
            Console.WriteLine(" the value of a/=b" + (a /= b));
            Console.WriteLine(" the value of a%=b" + (a %= b));



            // Logical Operators Examples
            Console.WriteLine(false && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && true);

            Console.WriteLine(true || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine(!false);



            //Comparison Operators Examples
            Console.WriteLine("Comparing between a and b");
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);

            */

            /*Math Class in c#
            float finalSpeed = Math.Min(131234,22);
            Console.WriteLine(finalSpeed);
            Console.WriteLine(Math.Abs(-238) + "this is abslouete value");*/


            // String Methods
            /* string password = "This is my password";
             string name = "Himanshu";
             Console.WriteLine(password);
             Console.WriteLine(password.Length);
             Console.WriteLine(password.ToLower());
             Console.WriteLine(password.ToUpper());
             Console.WriteLine("You have a strong password");


             Console.WriteLine($"Your name is {name}.This is Your Current as below {password}");*/

            // The condition is we need "[NPC] Dialogue!" 
            /*string line = "[NPC] Lets play the game!";
            int end = line.IndexOf("]");
            string speaker = line.Substring(1, end - 1);
            Console.WriteLine(speaker);

            int start1 = line.IndexOf("]");
            int start2 = line.IndexOf("!");
            Console.WriteLine(start1 + " start1");
            Console.WriteLine(start1 + 2 + " start1 + 2");

            string dialogue = line.Substring(start1 + 2, start2 - (start1 + 2));
            Console.WriteLine(dialogue+"\t"+"after \t");
            Console.WriteLine("Dialogue Printed2 ");*/


            // If else Operators
            /*int age = 32;
            if (age > 32)
            {
                Console.WriteLine("AGe is greater than 32");
            }
            else if (age > 3)
            {
                Console.WriteLine("Age is greather than 3 with else if condition");
            }
            else if (age > 2)
            {
                Console.WriteLine("Age is greater than 2 with else if codition");
            }
            else if (age > 1)
            {
                Console.WriteLine("Age is greater than 1 with else");
            }
            else
            {
                Console.WriteLine("Age is less than 32");
            }

            int distanceToPlayer = 23;
            distanceToPlayer = 20;
            if (distanceToPlayer < 23)
            {
                Console.WriteLine("Player has already Reached You");
            }

            bool doorlocked = true;

            if (doorlocked)
            {
                Console.WriteLine(doorlocked + "Door is Locked , First Find the Keys");
            }
*/

            /* If enemy is in range and player has ammo, shoot.

                 If enemy is in range but no ammo, play reload animation.

                 If enemy is far, move closer.

                 If player health is low, display warning.*/



            float PlayerShootingRange = 34f;
            bool PlayerHasAmmo = true;
            float distanceToEnemy = 2;
            float playerhealth = 100;



            Console.WriteLine("You have To Feed The current stats");
            Console.ReadLine();
            Console.WriteLine("Enter the PlayerShootingRange, REF: 34");
            string Psm = Console.ReadLine();
            PlayerShootingRange = Convert.ToInt32(Psm);
            Console.WriteLine("Now tell me whether the PlayerHasAmmo , REF: True or False");
            string PHA = Console.ReadLine();
            PlayerHasAmmo = bool.Parse(PHA);
            Console.WriteLine("Any Idea About Distance To Enemy REF:2");
            string DTE = Console.ReadLine();
            distanceToEnemy = float.Parse(DTE);
            Console.Write("Whats the Current Player health");
            playerhealth = float.Parse(Console.ReadLine());

            
            if (distanceToEnemy <= PlayerShootingRange && PlayerHasAmmo)
            {
                Console.WriteLine("Shoot");
            }
            else if (distanceToEnemy <= PlayerShootingRange && !PlayerHasAmmo)
            {
                Console.WriteLine("Reload");
            }
            else if (distanceToEnemy > PlayerShootingRange)
            {
                Console.WriteLine("Move Closer");
            }
            else if (playerhealth < 25)
            {
                Console.WriteLine("Player Health is Low");
            }
            else
            {
                Console.WriteLine("Player Health is Low");
            }


            Console.ReadLine();

        }

    }
}
