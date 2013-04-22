using System;
using System.Windows.Media;

namespace BarDiagram.Models
{
    public class BarItem
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public SolidColorBrush Color { get; set; }
        public const int Height = 40;
    }
}
