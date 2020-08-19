
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SSTC_ViewResources.Converters
{
    public sealed class InvertedBooleanToVisibilityConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = false;
            if (value is bool) flag = (bool)value;

            // proper inversion
            if (flag) return Visibility.Collapsed;
            else return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ((value is Visibility) && (((Visibility)value == Visibility.Visible)));
            return !result; // <- inversion
        }
    }
}
