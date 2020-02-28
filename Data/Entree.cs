/*
* Author: Nate Harrell
* Class: EntreeBaseClass.cs
* Purpose: To serve as a base class that other classes can implement.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree:IOrderItem
    {
        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public abstract List<string> SpecialInstructions { get; }

    }
}
