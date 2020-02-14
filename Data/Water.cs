/*
* Author: Nate Harrell
* Class: Water.cs
* Purpose: To represent the "Water" beverage.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// The price for water.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 0.12;
                    case (Size.Medium):
                        return 0.12;
                    case (Size.Large):
                        return 0.12;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }
        
        /// <summary>
        /// The calories for water.
        /// </summary>
        public override uint Calories { get { return 0; } }

        /// <summary>
        /// If the water is to be served with lemon (false by default).
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Any special instructions for the water beverage.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
