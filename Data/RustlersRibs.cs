using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs Entree.
    /// </summary>
    public class RustlersRibs
    {
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the Rustler's Ribs.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
