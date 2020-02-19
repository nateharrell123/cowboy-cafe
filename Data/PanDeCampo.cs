/*
* Author: Nate Harrell
* Class: PanDeCampo.cs
* Purpose: To serve as the Pan de Campo side item.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Pan de Campo side item.
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Price for the Pan de Campo side item.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories for the Pan de Campo side item.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override string ToString()
        {
            return Size.ToString() + " Pan De Campo";
        }
    }
}
