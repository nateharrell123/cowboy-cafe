using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    static class Menu
    {
        static IEnumerable<IOrderItem> Entrees()
        {
            var chili = new CowpokeChili();
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            var pecosPulledPork = new PecosPulledPork();
            var rustlersRibs = new RustlersRibs();
            var texasTripleBurger = new TexasTripleBurger();
            var trailBurger = new TrailBurger();

        }
    }
}
