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
    public static class BarInfoValidator
    {
        public static bool OneOrMoreFieldsEmpty(params string[] inputs)
        {
            foreach (string param in inputs)
                if (string.IsNullOrEmpty(param)) return true;

            return false;
        }

        public static bool IsValidDouble(string str)
        {
            try
            {
                double.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
