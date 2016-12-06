using DomainModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Client.Converters
{
    [ValueConversion(typeof(Location), typeof(string))]
    class LocationConverter : IValueConverter
    {
        Dictionary<Location, string> locations = new Dictionary<Location, string>();

        public LocationConverter()
        {
            locations.Add(Location.InStock, "На складе");
            locations.Add(Location.Absent, "Отсутствует");
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return locations[(Location)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = locations.FirstOrDefault(pair => pair.Value == (string)value);
            return result.Key;
        }
    }
}
