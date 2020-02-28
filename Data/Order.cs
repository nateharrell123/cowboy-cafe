using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // if any of these properties have changed, notify us. Subtotal Items, 
        public double Subtotal { get; }

        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }

        private static int lastOrderNumber;

        public uint OrderNumber { get; }

        public double Price { get; }


        private List<IOrderItem> items = new List<IOrderItem>();
        
    }
}
