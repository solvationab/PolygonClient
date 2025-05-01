using System;
using System.Reflection;
using Refit;

namespace PolygonClient.Extensions
{
    public class PolygonUrlParameterFormatter : IUrlParameterFormatter
    {
        private readonly IUrlParameterFormatter parent;

        public PolygonUrlParameterFormatter(DefaultUrlParameterFormatter defaultUrlParameterFormatter)
        {
            if (defaultUrlParameterFormatter == null)
                throw new ArgumentNullException(nameof(defaultUrlParameterFormatter));

            parent = defaultUrlParameterFormatter;
        }

        public string Format(object value, ICustomAttributeProvider attributeProvider, Type type)
        {
            if (value is DateTime dateTime)
            {
                return dateTime.ToString("yyyy-MM-dd");
            }
            
            return parent.Format(value, attributeProvider, type);
        }
    }
}