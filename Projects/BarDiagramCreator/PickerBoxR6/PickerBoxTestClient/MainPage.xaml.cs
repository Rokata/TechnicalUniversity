using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.Phone.Controls;
using Phone.Controls;
using Microsoft.Unsupported;
using BarDiagram.Models;

namespace BarDiagram 
{
    public partial class MainPage : PhoneApplicationPage
    {
        private PickerBoxDialog dialog;
        private int selectedIndex;
        private PickerBoxDialog customDialog;
        private DialogViewModel viewModel;
        private ColorItem currentColorItem;
        public static Bar bar;

        // Constructor
        public MainPage()
        {
            bar = new Bar();
            InitializeComponent();
            TiltEffect.SetIsTiltEnabled(this, true);
            InitPickerBoxDialog();
            InitCustomPickerDialog();

        }

        private void InitCustomPickerDialog()
        {
            // Initialize viewmodel
            this.viewModel = new DialogViewModel();
            this.currentColorItem = viewModel.Items[0];

            // Assing it to the page's DataContext
            this.DataContext = currentColorItem;
            this.customDialog = new PickerBoxDialog();
            this.customDialog.Title = "ACCENTS";

            // Assign our style to the dialog
            this.customDialog.Style = this.Resources["Custom"] as Style;
            this.customDialog.ItemSource = viewModel.Items;
            this.customDialog.Closed += new EventHandler(customDialog_Closed);
        }

        void customDialog_Closed(object sender, EventArgs e)
        {
            this.currentColorItem = (ColorItem)this.customDialog.SelectedItem;
            this.DataContext = currentColorItem;
        }

        private void InitPickerBoxDialog()
        {
            dialog = new PickerBoxDialog();
            // Assign data source and title
            dialog.Title = "FIRST DAY OF THE WEEK";
            // Hook up into closed event
            dialog.Closed += new EventHandler(dialog_Closed);
        }

        void dialog_Closed(object sender, EventArgs e)
        {
            selectedIndex = dialog.SelectedIndex;
            // Dialog closed. Assign the value to the button
        }

        private void buttonColor_Click(object sender, RoutedEventArgs e)
        {            
            this.customDialog.Show();
        }

        private void itemAddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (BarInfoValidator.OneOrMoreFieldsEmpty(dataNameTextBox.Text, quantityTextBox.Text))
            {
                MessageBox.Show("You must fill all data!");
                return;
            }

            double quantityValue;

            if (!BarInfoValidator.IsValidDouble(quantityTextBox.Text))
            {
                MessageBox.Show("You must enter valid floating-point number!");
                return;
            }
            else quantityValue = double.Parse(quantityTextBox.Text);

            BarItem newItem = new BarItem {
                                  Name = dataNameTextBox.Text,
                                  Quantity = quantityValue,
                                  Color = (SolidColorBrush)barItemColorFill.Fill
                              };

            if (bar.Contains(newItem))
                MessageBox.Show("Item with the specified name or color already exists!");
            else
            {
                bar.AddItem(newItem);
                MessageBox.Show("Item added to the bar!");
            }
        }

        private void barGeneratorBtn_Click(object sender, RoutedEventArgs e)
        {
            if (bar.ItemsCount < 1)
            {
                MessageBox.Show("Bar is empty!");
            }
            else
            {
                NavigationService.Navigate(new Uri("/BarPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void resetBarBtn_Click(object sender, RoutedEventArgs e)
        {
            bar.Clear();
            MessageBox.Show("All items were removed.");
        }
    }
}