﻿/*
* Author: Nate Harrell
* Class: Drink.cs
* Purpose: A base class for a Drink.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink:IOrderItem
    {
        public Size Size { get; set; } = Size.Small;

        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public bool Ice { get; set; } = true;

        public abstract List<string> SpecialInstructions { get; }
    }
}
