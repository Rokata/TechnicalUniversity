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
using System.Collections.Generic;

namespace PickerBoxTestClient
{
    public class DialogViewModel
    {
        public DialogViewModel()
        {
            this.Items = new List<ColorItem>()
            {
                new ColorItem() {Text="orange", Color = Colors.Orange},
                 new ColorItem() {Text="red", Color = Colors.Red},
                  new ColorItem() {Text="blue", Color = Colors.Blue},
                   new ColorItem() {Text="magenta", Color = Colors.Magenta},
                    new ColorItem() {Text="purple", Color = Colors.Purple},
                     new ColorItem() {Text="green", Color = Colors.Green},
                      new ColorItem() {Text="cyan", Color = Colors.Cyan},                      
                        new ColorItem() {Text="brown", Color = Colors.Brown},
                           new ColorItem() {Text="yellow", Color = Colors.Yellow},
            };
        }

        public List<ColorItem> Items
        {
            get;
            set;
        }
    }
}
