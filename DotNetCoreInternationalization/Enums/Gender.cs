using DotNetCoreInternationalization.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreInternationalization.Enums
{
    [EnumResource(typeof(GenderEnumResource))]
    public enum Gender { Male, Female, Unspecified}
}
