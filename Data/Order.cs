using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // if any of these properties have changed, notify us. Subtotal Items, 
        public double Subtotal => 0;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }
    }
}
