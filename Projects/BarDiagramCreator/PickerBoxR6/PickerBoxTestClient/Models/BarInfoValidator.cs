using System;

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
