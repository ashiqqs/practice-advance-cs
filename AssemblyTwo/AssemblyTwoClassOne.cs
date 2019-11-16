using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassOne:AssemblyOneClassTwo
    {
        public string GetProtectedInternal()
        {
            AssemblyOneClassTwo AOCT = new AssemblyOneClassTwo();
            return base.GetProtectedInternalProperty();
        }
    }
}
