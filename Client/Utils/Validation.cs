using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyPhotos.Utils
{
    internal class Validation
    {
        public static bool IsValidInput(string text)
        {
            return !string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text);
        }

        public static HashSet<T> ValidateAndAssign<T>(TextBox textBox, Func<string, T> apply) where T : class
        {
            return IsValidInput(textBox.Text) ? StringUtil.Parse(textBox.Text, apply) : new HashSet<T>();
        }
    }
}