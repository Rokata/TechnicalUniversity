using System;
using System.Net;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PickerBoxTestClient.Models
{
    public class Bar
    {
        private List<BarItem> items;
        private List<SolidColorBrush> itemsColors;
        private List<string> itemsNames;
        private double totalQuantity;

        public Bar()
        {
            items = new List<BarItem>();
            itemsColors = new List<SolidColorBrush>();
            itemsNames = new List<string>();
            totalQuantity = 0;
        }

        public void AddItem(BarItem item)
        {
            items.Add(item);
            itemsColors.Add(item.Color);
            itemsNames.Add(item.Name);
            UpdateTotalQuantity(item.Quantity);
        }

        public bool Contains(BarItem item)
        {
            if (itemsColors.Contains(item.Color) || itemsNames.Contains(item.Name))
                return true;

            return false;
        }

        private void UpdateTotalQuantity(double quantity)
        {
            totalQuantity += quantity;
        }
    }
}
