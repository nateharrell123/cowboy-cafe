using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Contains a price as well as any special instructions associated with an order item.
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        uint Calories { get; }



        List<string> SpecialInstructions { get; } // interfaces have to have getters and setters or methods. No fields exist in interfaces.
    }
}
