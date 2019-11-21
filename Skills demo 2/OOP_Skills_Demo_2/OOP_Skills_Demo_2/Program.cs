//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLibrary;

namespace OOP_Skills_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*                   PART 1                     *");
            Console.WriteLine("************************************************");
            //Create an Enemy and set all its properties
            Enemy enemy1 = new Enemy();

            enemy1.setName("The Enemy");
            enemy1.setXLoc(100.0);
            enemy1.setYLoc(100.0);
            enemy1.setVisible(true);
            enemy1.setAlive(true);
            enemy1.setTeamName("The Enemy Team");
            enemy1.setPlayersDestroyed(0);

            //Creates a Player and set all its properties
            Player player1 = new Player();
            player1.setName("The Player");
            player1.setXLoc(0.0);
            player1.setYLoc(0.0);
            player1.setVisible(true);
            player1.setAlive(true);
            player1.setTeamName("The Player Team");
            player1.setEnemiesDestroyed(0);

            //Displaying the Enemy Information
            Console.WriteLine("************" + enemy1.getName() + "************");
            Console.WriteLine("Enemy Name           : " +enemy1.getName());
            Console.WriteLine("Enemy Location       : (X" +enemy1.getXLoc()+" , Y"+enemy1.getYLoc()+")");
            Console.WriteLine("Enemy Visible        : " + enemy1.isVisible());
            Console.WriteLine("Enemy Alive          : " + enemy1.isAlive());
            Console.WriteLine("Team Name            : " + enemy1.getTeamName());
            Console.WriteLine("Players Destroyed    : " + enemy1.getPlayersDestroyed());

            //displaying the Player Information
            Console.WriteLine("");
            Console.WriteLine("************" + player1.getName() + "************");
            Console.WriteLine("Player Name          : " + player1.getName());
            Console.WriteLine("Player Location      : (X" + player1.getXLoc() + " , Y" + player1.getYLoc() + ")");
            Console.WriteLine("Player Visible       : " + player1.isVisible());
            Console.WriteLine("Player Alive         : " + player1.isAlive());
            Console.WriteLine("Team Name            : " + player1.getTeamName());
            Console.WriteLine("Enemies Destroyed    : " + player1.getEnemiesDestroyed());
            Console.WriteLine("");
            Console.WriteLine("Press any Key to Continue");

            Console.ReadKey();

            //Clears the display
            Console.Clear();

            //Get both Enemy and Player to Jump
            enemy1.jump();
            player1.jump();

            //Displaying the Enemy's and Player's new position
            Console.Write(enemy1.getName() +"  : ");
            enemy1.Location();
            Console.WriteLine("");
            Console.Write(player1.getName() + " : ");
            player1.Location();

            Console.WriteLine("");
            Console.WriteLine("Press any Key to Continue");

            Console.ReadKey();

            //Enemy Attack and Print new Location
            enemy1.attack();
            Console.Write(enemy1.getName() + "  : ");
            enemy1.Location();
            Console.WriteLine("");

            //Player Retreat and Print new Location
            player1.retreat();
            Console.Write(player1.getName() + " : ");
            player1.Location();

            Console.WriteLine("");
            Console.WriteLine("Press any Key to Continue");

            Console.ReadKey();

            //clear screen for part 2
            Console.Clear();

            Console.WriteLine("************************************************");
            Console.WriteLine("*                   PART 2                     *");
            Console.WriteLine("************************************************");

            //creating the player vector 1
            Vector PlayerVect1 = new Vector(player1.getXLoc(), player1.getYLoc());

            //creating player vector 2(player vector 1 multiplied by 7)
            Vector playerVect2 = new Vector();
            playerVect2 = PlayerVect1 * 7;

            //printing resulting Vector to the Screen
            Console.Write("playerVect2 = ");
            playerVect2.printVector();

            //creating the enemy vector 1
            Vector EnemyVect1 = new Vector(enemy1.getXLoc(), enemy1.getYLoc());

            //creating the player vector 3(player vector 2 + enemy vector 1)
            Vector playerVect3 = new Vector();
            playerVect3 = playerVect2 + EnemyVect1;

            //printing resulting Vector to the Screen
            Console.Write("playerVect3 = ");
            playerVect3.printVector();

            Console.ReadKey();

        }
    }
}
