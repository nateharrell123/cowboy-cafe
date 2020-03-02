using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili.
    /// </summary>
    public class AngryChicken : Entree
    {
        private bool bread = true;
        private bool pickle = true;
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }


        /// <summary>
        /// The calories of the Cowpoke Chili Entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }

        }

        /// <summary>
        /// If bread is being served with the Cowpoke Chili.
        /// </summary>
        public bool Bread
        {
            get
            {
                return bread;
            }
            set
            {
                bread = value;
            }
        }

        /// <summary>
        /// If the Cowpoke Chili has pickle.
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// Special instructions for the Angry Chicken entree.
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

        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
