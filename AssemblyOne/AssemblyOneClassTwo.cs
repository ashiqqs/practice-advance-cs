using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class AssemblyOneClassTwo
    {
        internal string GetInternalProperty()
        {
            AssemblyOneClassOne AOCO = new AssemblyOneClassOne {
                InternalProperty="I am Internal",
            };
            return AOCO.InternalProperty;
        }

        protected internal string GetProtectedInternalProperty()
        {
            AssemblyOneClassOne AOCO = new AssemblyOneClassOne
            {
                ProtectedInternalProperty = "I am Protected Internal"
            };
            return AOCO.ProtectedInternalProperty;
        }
    }
}
