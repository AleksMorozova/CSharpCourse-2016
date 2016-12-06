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
    class LocationCollectionConverter : IValueConverter
    {
        LocationConverter converter = new LocationConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<string> values = new List<string>();
            foreach (Location location in (IEnumerable<Location>)value)
            {
                values.Add(converter.Convert((object)location, targetType, parameter, culture).ToString());
            }

            return values;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<Location> values = new List<Location>();
            foreach (string locationName in (IEnumerable<string>)value)
            {
                values.Add((Location)converter.Convert((object)locationName, targetType, parameter, culture));
            }

            return values;
        }
    }
}
