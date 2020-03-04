using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods // extension methods must be static
    {
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject // parameter means that this is going to be an extension method, and it's going to be attached to every DepencyObject.
            // This will only search for FrameWorkElements.
        {
            var parent = VisualTreeHelper.GetParent(element); // direct parent of this element

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>(); // recursive
        }
    }
}
