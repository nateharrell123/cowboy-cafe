using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class that represents the Trailburger entree.
    /// </summary>
    public class Trailbuger
    {
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        /// <summary>
        /// The price of the Trailburger entree.
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories for the Trailburger entree.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// If the Trailburger entree is to be served with ketchup.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }
        /// <summary>
        /// If the entree is to be served with mustard.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        /// <summary>
        /// If the entree is to be served with pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the entree is to be served with cheese.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Any special instructions for the Trailburger entree.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}
