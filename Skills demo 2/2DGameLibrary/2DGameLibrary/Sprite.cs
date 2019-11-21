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
    /// Class for a Sprite
    /// </summary>
    public class Sprite
    {
        //Sprites variables
        private string name;
        private double xLoc;
        private double yLoc;
        private bool visible;
        private bool alive;

        //Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Sprite()
        {
            this.name = "Sprite";
            this.xLoc = 0.0;
            this.yLoc = 0.0;
            this.visible = true;
            this.alive = true;
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="sName">Sprite Name : String</param>
        /// <param name="locX">Sprite's X location : Double</param>
        /// <param name="locY">Sprite's Y location : Double</param>
        /// <param name="seeable">Is Sprite Visible? : Bool</param>
        /// <param name="active">Is Sprite Alive? : Bool</param>
        public Sprite(string sName, double locX, double locY, bool seeable, bool active)
        {
            this.name = sName;
            this.xLoc = locX;
            this.yLoc = locY;
            this.visible = seeable;
            this.alive = active;
        }

        //gets and sets

        //gets
        /// <summary>
        /// gets the name of the sprite
        /// </summary>
        /// <returns>Sprite name : String</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        /// gets the X location of the sprite
        /// </summary>
        /// <returns>X Location : Double</returns>
        public double getXLoc()
        {
            return this.xLoc;
        }
        /// <summary>
        /// gets the Y location of the sprite
        /// </summary>
        /// <returns>Y location : Double</returns>
        public double getYLoc()
        {
            return this.yLoc;
        }
        /// <summary>
        /// Bool to see if Sprite is visible or not
        /// </summary>
        /// <returns>Is Sprite visible? : Bool</returns>
        public bool isVisible()
        {
            return this.visible;
        }
        /// <summary>
        /// Bool to see if Sprite is alive or not
        /// </summary>
        /// <returns>Is Sprite alive? : Bool</returns>
        public bool isAlive()
        {
            return this.alive;
        }

        //sets
        /// <summary>
        /// Set the nmae of the Sprite
        /// </summary>
        /// <param name="nameIn">Sprite name : String</param>
        public void setName(string nameIn)
        {
            this.name = nameIn;
        }
        /// <summary>
        /// sets the X location of the Sprite 
        /// </summary>
        /// <param name="xLocIn">X location of the Sprite : Double</param>
        public void setXLoc(double xLocIn)
        {
            this.xLoc = xLocIn;
        }
        /// <summary>
        /// sets the Y location of the Sprite
        /// </summary>
        /// <param name="yLocIn">Y location of the Sprite : Double</param>
        public void setYLoc (double yLocIn)
        {
            this.yLoc = yLocIn;
        }
        /// <summary>
        /// sets if the sprite is visible or not
        /// </summary>
        /// <param name="visibleIn">is the Sprite is visible : bool</param>
        public void setVisible(bool visibleIn)
        {
            this.visible = visibleIn;
        }
        /// <summary>
        /// sets if the sprite is alive or not
        /// </summary>
        /// <param name="aliveIn">is the Sprite is alive : Bool</param>
        public void setAlive(bool aliveIn)
        {
            this.alive = aliveIn;
        }
        //Behaviours
        /// <summary>
        /// gets the sprite to say "I am a sprite"
        /// </summary>
        public virtual void speak()
        {
            Console.WriteLine("I am a sprite");
        }
        /// <summary>
        /// Jump increases Y location by 10
        /// </summary>
        public void jump()
        {
            this.yLoc = this.yLoc + 10;
        }
        /// <summary>
        /// Prints the current location of the sprite 
        /// </summary>
        public void Location()
        {
            Console.WriteLine("My current location is X " + getXLoc() + " , Y " + getYLoc());
        }
    }
}
