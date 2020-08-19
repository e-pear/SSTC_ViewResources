
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Collections;

namespace SSTC_ViewResources.Converters
{
    public sealed class EmptyCollectionToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = false;
            if (value is ICollection)
            {
                ICollection collection = value as ICollection;
                if (collection.Count == 0) flag = true;
            }
            return flag;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
