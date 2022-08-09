using DP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Making_Project
{ 
    class MyConverter : TypeConverter
    {
        /// <summary>
        /// Determines if the source type can be converted.
        /// </summary>
        /// <param name="context">The type description context.</param>
        /// <param name="sourceType">The type to convert to Person.</param>
        /// <returns>True if the sourceType can be converted.</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type
       sourceType)
        {
            //Since we are dealing with a XAML property, the value must be of type string.
            if (sourceType == typeof(string))
                return true;
            //Otherwise, try the base implementation.
            return base.CanConvertFrom(context, sourceType);
        }
        /// <summary>
        /// Determines whether the destination type can be converted.
        /// </summary>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type
       destinationType)
        {
            return base.CanConvertTo(context, destinationType);
            
        }
        /// <summary>
        /// Converts from the Person value to the XAML string representation.
        /// </summary>
        /// <param name="context">Type description context.</param>
        /// <param name="culture">The string culture for localization purposes.</param>
        /// <param name="value">The value to convert.</param>
        /// <returns>A person object with the properties specified in the value string.</returns>

        public override object ConvertFrom(ITypeDescriptorContext context,
 System.Globalization.CultureInfo culture, object value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            try
            {
                Person convertedPerson = Person.Parse((string)value);
                return convertedPerson;
            }
            catch (Exception ex)
            {
                //Log the exception and try the base implementation.
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
 /// <summary>
 /// Converts a person object to the XAML representation.
 /// </summary>
 /// <param name="context">The type description context.</param>
 /// <param name="culture">The string culture for localization.</param>
 /// <param name="value">The XAML string representing the person.</param>
 /// <param name="destinationType">The type to convert to (Person).</param>
 /// <returns></returns>

 public override object ConvertTo(ITypeDescriptorContext context,
System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if (value is Person)
            {
                var personObject = (Seeker)value;
                var xamlAttributeValue = personObject.ToString();
                return xamlAttributeValue;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }

}
