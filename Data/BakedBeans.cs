﻿/*
* Author: Nate Harrell
* Class: BakedBeans.cs
* Purpose: To represent the Baked beans side item
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Baked Beans side item.
    /// </summary>
    public class BakedBeans : Side
    {

        /// <summary>
        /// The price for the Baked Beans side item.
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
                        throw new NotImplementedException("Unknown price.");
                }
            }
        }


        /// <summary>
        /// The calories for the Baked Beans side item.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }



        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
