using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using BarDiagram.Models;
using System.Windows.Media;

namespace BarDiagram
{
    public partial class BarPage : PhoneApplicationPage
    {
        private static int offset;
        private const int LegendSize = 25;

        public BarPage()
        {
            offset = 0;
            InitializeComponent();
            GenerateDiagram();
            VisualizeLegend(MainPage.bar.Items.Count);
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

        private void VisualizeLegend(int itemsCount)
        {
            double currentLength = BarItem.Height * (offset + 1);

            for (int i = 0; i < itemsCount; i++)
            {
                double currentMarginTop = currentLength + i * (LegendSize + 15);

                ContentPanel.Children.Add(new Rectangle()
                {
                    Width = LegendSize,
                    Height = LegendSize,
                    Fill = MainPage.bar.Items[i].Color,
                    Margin = new Thickness(0, currentMarginTop, 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left
                });

                ContentPanel.Children.Add(new TextBlock()
                {
                    Text = MainPage.bar.Items[i].Name,
                    Margin = new Thickness(2 * LegendSize, currentMarginTop - 10, 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    FontSize = 30
                });
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}