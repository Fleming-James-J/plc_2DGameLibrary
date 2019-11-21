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
    /// Class for Vector Maths
    /// </summary>
    public class Vector
    {
        //Vector Variables
        private double i;
        private double j;

        //Constuctors
        /// <summary>
        /// Default Constructor for the Vector
        /// </summary>
        public Vector()
        {
            this.i = 0.0;
            this.j = 0.0;
        }
        /// <summary>
        /// Overloaded Constructor for the Vector
        /// </summary>
        /// <param name="ii"> i of the Vector : Double </param>
        /// <param name="jj"> j of the Vector : Double </param>
        public Vector(double ii, double jj)
        {
            this.i = ii;
            this.j = jj;
        }

        //gets and sets
        //gets
        /// <summary>
        /// gets the i component of the Vector
        /// </summary>
        /// <returns>i component : Double</returns>
        public double getI()
        {
            return this.i;
        }
        /// <summary>
        /// gets the j component of the Vector
        /// </summary>
        /// <returns>j component : Double</returns>
        public double getJ()
        {
            return this.j;
        }
        //sets
        /// <summary>
        /// sets the i component of the Vector
        /// </summary>
        /// <param name="iIN">i component : Double</param>
        public void setI(double iIN)
        {
            this.i = iIN;
        }
        /// <summary>
        /// sets the j component of the Vector
        /// </summary>
        /// <param name="jIN">j component : Double</param>
        public void setJ(double jIN)
        {
            this.j = jIN;
        }
        //behaviours
        /// <summary>
        /// Prints the current Vector values in i,j form
        /// </summary>
        public void printVector()
        {
            Console.WriteLine(this.i + "i , " + this.j+"j");
        }
        /// <summary>
        /// Overloaded Operator for adding 2 vectors 
        /// </summary>
        /// <param name="a">First Vector : Vector</param>
        /// <param name="b">Second Vector : Vector</param>
        /// <returns>Result of adding the two Vectors</returns>
        public static Vector operator +(Vector a, Vector b)
        {
            //creates c vector that is the result of Vector a + Vector b 
            Vector c = new Vector();

            //sets Vector c's i,j to ai + bi , aj + bj
            c.setI(a.getI() + b.getI());
            c.setJ(a.getJ() + b.getJ());

            return c;
            
        }
        /// <summary>
        /// Overloaded Operator for multiplying a Vector by a Scaler
        /// </summary>
        /// <param name="a">Vector : Vector</param>
        /// <param name="scaler">Scaler : Double</param>
        /// <returns>Vector Multiplied by Scaler : Vector</returns>
        public static Vector operator *(Vector a, double scaler)
        {
            //creates a vector that will be the result of vector a by the Scaler
            Vector ans = new Vector();

            //Sets Vector ans's i,j with the result of mulitplying Vector a's i,j by the scaler
            ans.setI(a.getI() * scaler);
            ans.setJ(a.getJ() * scaler);

            return ans;
        }
        /// <summary>
        /// Overloaded Operator for multiplying a Scaler by a Vector
        /// </summary>
        /// <param name="scaler">Scaler : Double</param>
        /// <param name="a">Vector : Vector</param>
        /// <returns>Scaler multiplied by Vector : Vector</returns>
        public static Vector operator *(double scaler, Vector a)
        {
            //creates a vector that will be the result of the Scaler by Vector a
            Vector ans = new Vector();

            //Sets Vector ans's i,j with the result of mulitplying the scaler by the Vector a's i,j 
            ans.setI(a.getI() * scaler);
            ans.setJ(a.getJ() * scaler);

            return ans;
        }
    }
}
