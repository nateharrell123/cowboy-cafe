﻿/*
* Author: Nate Harrell
* Class: CowboyCoffee.cs
* Purpose: To represent the Cowboy Coffee drink menu item.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The price for the Cowboy Coffee beverage.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 0.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The calories for the Cowboy Coffee beverage.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }
        /// <summary>
        /// Any special instructions for the Cowboy Coffee beverage.
        /// </summary>

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        private bool cream = false;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// If there's room for cream (false by default).
        /// </summary>
        public bool RoomForCream
        {
            get { return cream; }
            set
            {
                cream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = false;
        /// <summary>
        /// If there's ice included (false by default).
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Override method to print the name of the beverage based on size, and if it's decaf or not.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           switch(Decaf)
           {
                case true:
                    return Size + " Decaf Cowboy Coffee";
                case false:
                    return Size + " Cowboy Coffee";
                default:
                    throw new NotImplementedException();
           }
        }   
    }
}
