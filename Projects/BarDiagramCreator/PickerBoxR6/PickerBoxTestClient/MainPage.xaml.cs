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
using Phone.Controls;
using Microsoft.Unsupported;
using PickerBoxTestClient.Models;

namespace PickerBoxTestClient
{
    public partial class MainPage : PhoneApplicationPage
    {
        PickerBoxDialog dialog;
        private int selectedIndex;
        PickerBoxDialog customDialog;
        DialogViewModel viewModel;
        ColorItem currentColorItem;
        private Bar bar;

        // Constructor
        public MainPage()
        {
            this.bar = new Bar();
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
    }
}