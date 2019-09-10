using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;

namespace DotNetCoreInternationalization.Enums
{
    public static class EnumExtensions
    {
        public static string ToLocalizedString(this Enum en)
        {
            var typeInfo = en.GetType().GetTypeInfo();
            var attribute = typeInfo.GetCustomAttribute<EnumResourceAttribute>();
            if (attribute == null) {
                return en.ToString();
            }
            return new ResourceManager(attribute.ResourceType).GetString(en.ToString(), CultureInfo.CurrentUICulture);
        }
    }
}
