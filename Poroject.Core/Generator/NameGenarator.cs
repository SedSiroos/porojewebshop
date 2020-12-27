using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.Generator
{
    public class NameGenarator
    {
        public static string GeneratorUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
