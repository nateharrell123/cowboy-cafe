/*
* Author: Nate Harrell
* Class: PecosPulledPork.cs
* Purpose: To represent the Pecos Pulled Pork entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork:Entree, INotifyPropertyChanged
    {
        private bool bread = true;
        private bool pickle = true;
        /// <summary>
        /// The price of the Pecos Pulled Pork entree.
        /// </summary>
        public override double Price
        {
            get {return 5.88;}
        }

        /// <summary>
        /// The calories for the Pecos Pulled Pork entree.
        /// </summary>
        public override uint Calories
        {
            get {return 528;}
        }

        /// <summary>
        /// If the entree is to be served with bread.
        /// </summary>
        public bool Bread
        {
            get {return bread;}
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the entree is to be served with pickle.
        /// </summary>
        public bool Pickle
        {
            get {return pickle;}
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Special instructions for the Pecos Pulled Pork entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");

                return instructions;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Overrides the ToString() method and prints the name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
