/*
* Author: Nate Harrell
* Class: ChiliCheeseFries.cs
* Purpose: To represent the Chili Cheese Fries side item
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Chili Cheese Fries Side.
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Calories for the Chili Cheese Fries Side item.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Price for the Chili Cheese Fries Side item.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException("Unknown price");
                }
            }
        }
    }
}
