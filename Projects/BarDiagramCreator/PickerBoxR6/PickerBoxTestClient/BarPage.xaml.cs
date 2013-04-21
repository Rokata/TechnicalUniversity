using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PickerBoxTestClient.Models;

namespace PickerBoxTestClient
{
    public partial class BarPage : PhoneApplicationPage
    {
        private int offset;

        public BarPage()
        {
            offset = 0;
            InitializeComponent();
            GenerateDiagram();
        }

        private void GenerateDiagram()
        {
            double contentPanelWidth = Application.Current.Host.Content.ActualWidth - (ContentPanel.Margin.Left * 2);

            foreach (BarItem item in MainPage.bar.Items)
            {
                double percentage = MainPage.bar.GetItemShare(item);
                string textBlockText = (percentage * 100) + "%";

                ContentPanel.Children.Add(new Border()
                {
                    Background = item.Color,
                    Child = new TextBlock() { Text = textBlockText, TextAlignment = TextAlignment.Center, VerticalAlignment = VerticalAlignment.Center },
                    Width = percentage * contentPanelWidth,
                    Height = BarItem.Height,
                    Margin = new Thickness(0, BarItem.Height * offset, 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left
                });

                offset++;
            }
        }
    }
}