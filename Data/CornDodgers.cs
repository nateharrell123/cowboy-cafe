/*
* Author: Nate Harrell
* Class: CornDodgers.cs
* Purpose: To represent the Corn Dodgers side entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the corn dodgers side item.
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The price for the Corn Dodgers side item.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// The calories for the Corn Dodgers side item.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";
        }
    }
}
