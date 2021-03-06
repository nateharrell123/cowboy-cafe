﻿/*
* Author: Nate Harrell
* Class: TexasTripleBurger.cs
* Purpose: To represent the Texas Triple Burger entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree.
    /// </summary>
    public class TexasTripleBurger : Entree, INotifyPropertyChanged
    {
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool bun = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        private bool bacon = true;
        private bool egg = true;
        /// <summary>
        /// The cost for a Texas Triple Burger entree.
        /// </summary>
        public override double Price
        {
            get {return 6.45;}
        }

        public bool Bun
        {
            get { return bun; }
            set
            { 
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// The calories for the Texas Triple Burger entree.
        /// </summary>
        public override uint Calories
        {
            get {return 698;}
        }

        /// <summary>
        /// If the Texas Triple Burger entree is to be served with ketchup.
        /// </summary>
        public bool Ketchup
        {
            get {return ketchup;}
            set 
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// If the Texas Triple Burger entree is to be served with mustard.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// If the Texas Triple Burger entree is to be served with pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the Texas Triple Burger entree is to be served with cheese.
        /// </summary>
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

        /// <summary>
        /// If the entree is to be served with tomato.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the entree is to be served with lettuce.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the entree is to be served with mayo.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the entree is to be served with bacon.
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set 
            { 
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the entree is to be served with egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            { 
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Any special instructions for the Trailburger entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
                if (!bun) instructions.Add("hold bun");

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
            return "Texas Triple Burger";
        }
    }
}
