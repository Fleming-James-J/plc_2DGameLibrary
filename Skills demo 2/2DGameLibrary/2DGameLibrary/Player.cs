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
    /// Class for a Player that inherits from the Sprite Class
    /// </summary>
    public class Player : Sprite
    {
        //Player variables
        private string teamName;
        private int enemiesDestroyed;

        //constructor
        /// <summary>
        /// The default constructor for the Player
        /// </summary>
        public Player()
        {
            this.teamName = "Team 1";
            this.enemiesDestroyed = 0;
        }

        //gets and sets
        //gets
        /// <summary>
        /// gets the Team Name of the Player
        /// </summary>
        /// <returns>Team Name : String</returns>
        public string getTeamName()
        {
            return this.teamName;
        }
        /// <summary>
        /// find out how many enemies the Player has destroyed
        /// </summary>
        /// <returns>Enemies Player has Destroyed : Int</returns>
        public int getEnemiesDestroyed()
        {
            return this.enemiesDestroyed;
        }
        //sets
        /// <summary>
        /// Sets the Team Name of Player
        /// </summary>
        /// <param name="teamNameIn">Team Name : String</param>
        public void setTeamName(string teamNameIn)
        {
            this.teamName = teamNameIn;
        }
        /// <summary>
        /// sets the Amount of Enemies the Player has destroyed
        /// </summary>
        /// <param name="enemiesDestroyedIn">Enemies Player has destroyed : Int</param>
        public void setEnemiesDestroyed(int enemiesDestroyedIn)
        {
            this.enemiesDestroyed = enemiesDestroyedIn;
        }

        //Behaviours
        /// <summary>
        /// Overridden method to allow the Players Speak be different from that of the Sprite base class
        /// </summary>
        public override void speak()
        {
            Console.WriteLine("I am the Player");
        }
        /// <summary>
        /// method to allow the player Retreat Xlocation - 10 when used
        /// </summary>
        public void retreat()
        {
            this.setXLoc(this.getXLoc() - 10);
        }

    }
}
