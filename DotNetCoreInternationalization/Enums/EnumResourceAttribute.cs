using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreInternationalization.Enums
{
    public class EnumResourceAttribute : Attribute
    {
        public  Type ResourceType { get; private set; }

        public EnumResourceAttribute(Type type)
        {
            this.ResourceType = type;
        }
    }
}
