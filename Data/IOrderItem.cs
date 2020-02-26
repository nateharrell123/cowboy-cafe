using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        double Price { get; }

        List<string> SpecialInstructions { get; } // interfaces have to have getters and setters or methods. No fields exist in interfaces.
    }
}
