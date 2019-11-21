//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    /// <summary>
    /// Class for an Enemy that inherits from the Sprite class
    /// </summary>
    public class Enemy : Sprite
    {
        //Enemy Variables
        private string teamName;
        private int playersDestroyed;

        //constructor
        /// <summary>
        /// default constructor for an enemy
        /// </summary>
        public Enemy()
        {
            this.teamName = "Team 2";
            this.playersDestroyed = 0;
        }

        //gets and sets
        
        //gets
        /// <summary>
        /// gets the team Name of the Enemy
        /// </summary>
        /// <returns>Team Name of the Enemy : String</returns>
        public string getTeamName()
        {
            return this.teamName;
        }
        /// <summary>
        /// gets the Amount of Players the Enemies has Destroyed
        /// </summary>
        /// <returns>the Amount Players the Enemy has Destroyed : Int</returns>
        public int getPlayersDestroyed()
        {
            return this.playersDestroyed;
        }

        //sets
        /// <summary>
        /// sets the Team Name of the Enemy
        /// </summary>
        /// <param name="teamNamein">Team Name of the Enemy : String</param>
        public void setTeamName(string teamNamein)
        {
            this.teamName = teamNamein;
        }
        /// <summary>
        /// Sets the Amount of Players the Enemy has Destroyed
        /// </summary>
        /// <param name="playersDestroyedIn">the Amount of Players the Enemy has Destroyed : Int</param>
        public void setPlayersDestroyed(int playersDestroyedIn)
        {
            this.playersDestroyed = playersDestroyedIn;
        }

        //behaviours
        /// <summary>
        /// Overridden operator so that Enemy speaks differently to it's base class Sprite
        /// </summary>
        public override void speak()
        {
            Console.WriteLine("I am an Enemy");
        }

        /// <summary>
        /// method to Allow the Enemy Attack by adding 10 to its X location
        /// </summary>
        public void attack()
        {
            this.setXLoc(this.getXLoc() + 10);
        }
    }
}
