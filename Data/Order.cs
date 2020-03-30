using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // if any of these properties have changed, notify us. Subtotal Items, 
        private List<IOrderItem> items = new List<IOrderItem>(); // list of stuff we've added to the order
        private double subtotal;
        /// <summary>
        /// Gets the subtotal based on IOrderItems in the 'Items' IEnumerable
        /// </summary>
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

        /// <summary>
        /// Returns an array of IOrderItems.
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        
        /// <summary>
        /// Adds an IOrderItem to the 'items' list in this class. Also updates that the 'PropertyChanged' property has changed.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged; // TODO: change code later
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes an IOrderItem from the 'items' list. Also updates that the 'PropertyChanged' property has changed.
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            if(item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        private static uint lastOrderNumber = 1;

        public uint OrderNumber => lastOrderNumber++;
        
    }
}
