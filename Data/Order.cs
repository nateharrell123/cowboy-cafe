using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // if any of these properties have changed, notify us. Subtotal Items, 
        private List<IOrderItem> items = new List<IOrderItem>();
        private double subtotal;
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private static uint lastOrderNumber = 1;

        public uint OrderNumber => lastOrderNumber++;
        
    }
}
