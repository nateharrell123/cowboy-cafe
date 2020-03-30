/*
* Author: Nate Harrell
* Class: Side.cs
* Purpose: To serve as a base class for other side items to implement.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side:IOrderItem, INotifyPropertyChanged
    {

        private Size size;

        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual List<string> SpecialInstructions { get; }
    }
}
