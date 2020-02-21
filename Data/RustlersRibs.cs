/*
* Author: Nate Harrell
* Class: RustlersRibs.cs
* Purpose: To represent the Rustler's Ribs entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs Entree.
    /// </summary>
    public class RustlersRibs:Entree
    {
        public override double Price
        {
            get {return 7.50;}
        }

        /// <summary>
        /// The calories of the Rustler's Ribs.
        /// </summary>
        public override uint Calories
        {
            get {return 894;}
        }

        /// <summary>
        /// Any special instructions for the Rustler's Ribs entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get { var instructions = new List<string>(); return instructions;}
        }

        /// <summary>
        /// Overrides the ToString() method and prints the name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
