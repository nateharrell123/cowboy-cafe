using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken.
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged 
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
        /// The calories of the Angry Chicken Entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }

        }

        /// <summary>
        /// If bread is being served with the Angry Chicken.
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the Angry Chicken has pickle.
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
