/*
* Author: Nate Harrell
* Class: ChiliCheeseFries.cs
* Purpose: To represent the Chili Cheese Fries side item
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Chili Cheese Fries Side.
    /// </summary>
    public class ChiliCheeseFries : Side, INotifyPropertyChanged
    {
        private Size size;

        public override Size Size
        {
            get { return size; }
            set 
            { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

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
        private bool cheese = true;

        public bool Cheese
        {
            get { return cheese; }
            set 
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool chili = true;
        public bool Chili
        {
            get { return chili; }
            set
            {
                chili = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Chili"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!chili) instructions.Add("hold chili");

                return instructions;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
