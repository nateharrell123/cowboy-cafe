/*
* Author: Nate Harrell
* Class: JerkedSoda.cs
* Purpose: To represent the Jerked Soda beverage.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// Gets the price of the Jerked Soda based on what size it is.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Gets the calories for the Jerked Soda based on what size it is.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 146;
                    case (Size.Large):
                        return 198;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Any special instructions for the Jerked Soda beverage.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice.");

                return instructions;
            }
        }
    }
}
