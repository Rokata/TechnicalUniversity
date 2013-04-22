using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace BarDiagram.Models
{
    public class Bar
    {
        private List<BarItem> items;
        private List<SolidColorBrush> itemsColors;
        private List<string> itemsNames;
        private double totalQuantity;

        public List<BarItem> Items
        {
            get { return this.items; }
        }

        public double TotalQuantity
        {
            get { return this.totalQuantity; }
        }

        public int ItemsCount
        {
            get { return this.items.Count; }
        }

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

        public double GetItemShare(BarItem item)
        {
            return Math.Round((item.Quantity / totalQuantity), 4);
        }

        public void Clear()
        {
            items.Clear();
            itemsColors.Clear();
            itemsNames.Clear();
            totalQuantity = 0;
        }
    }
}
