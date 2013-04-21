using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PickerBoxTestClient.Models
{
    public class BarItem
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public SolidColorBrush Color { get; set; }
    }
}
