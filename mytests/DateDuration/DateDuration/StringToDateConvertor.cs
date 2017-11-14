using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DateDuration
{
    class StringToDateConvertor : IValueConverter
    {
        // Date to string
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value is DateTime)
            {
                // if value is datetime. then we simply return it
                return value;
            }
            else
            {
                //if value is string, we need to conert to datetime type.
                DateTime myDatetime = new DateTime();
                myDatetime = System.Convert.ToDateTime(value);
                return myDatetime;
            }

        }

        // string to date
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {

            if(value is string )
            {
                DateTime myDatetime = new DateTime();
                myDatetime = System.Convert.ToDateTime(value);
                return myDatetime;
            }

            return new DateTime();
        }
    }
}
