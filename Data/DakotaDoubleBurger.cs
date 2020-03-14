using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Dakota Double Burger entree.
    /// </summary>
    public class DakotaDoubleBurger:Entree, INotifyPropertyChanged
    {
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        private bool bun = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        /// <summary>
        /// The cost for a Dakota Double Burger entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// The calories for the Dakota Double Burger entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If the Dakota Double Burger entree is to be served with ketchup.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ketchup = value;
            }
        }
        /// <summary>
        /// If the Dakota Double Burger entree is to be served with mustard.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                mustard = value; 
            }
        }
        /// <summary>
        /// If the Dakota Double Burger entree is to be served with pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                pickle = value; 
            }
        }

        /// <summary>
        /// If the Dakota Double Burger entree is to be served with cheese.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                cheese = value;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                tomato = value; 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                lettuce = value; 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                mayo = value;
            }
        }

        public bool Bun
        {
            get { return bun; }
            set 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                bun = value; 
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
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Overrides the tostring() method and prints the name of the entree.
        /// </summary>
        /// <returns>"Dakota Double Burger"</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
