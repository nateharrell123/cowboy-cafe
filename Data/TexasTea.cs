/*
* Author: Nate Harrell
* Class: TexasTea.cs
* Purpose: To represent the Texas Tea beverage.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// If it's sweet tea (true by default).
        /// </summary>
        public bool Sweet { get; set; } = true;
        /// <summary>
        /// If lemon is to be served with the tea (true by default).
        /// </summary>
        public bool Lemon { get; set; } = true;

        /// <summary>
        /// Price of the Texas Tea beverage.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 1.10;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }
        /// <summary>
        /// Calories for the Texas Tea beverage.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 10;
                    case (Size.Medium):
                        return 22;
                    case (Size.Large):
                        return 36;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }
        /// <summary>
        /// Any special instructions for the Texas Tea beverage.
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
