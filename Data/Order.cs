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

        public IEnumerable<IOrderItem> Items { get; }

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }

        private int lastOrderNumber;

        public uint OrderNumber { get; }

        private List<IOrderItem> items = new List<IOrderItem>();

        
    }
}
