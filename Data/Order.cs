using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged; // if any of these properties have changed, notify us. Subtotal Items, 
        public double Subtotal { get; }

        public IEnumerable<IOrderItem> Items { get; }

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }

        private int lastOrderNumber;

        public uint OrderNumber { get; }

        public double Price => throw new NotImplementedException();

        public List<string> SpecialInstructions => throw new NotImplementedException();

        private List<IOrderItem> items = new List<IOrderItem>();

        
    }
}
