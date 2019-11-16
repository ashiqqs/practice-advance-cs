using AssemblyOne;
using AssemblyTwo;
using PracticeAdvanceCS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvanceCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            AssemblyTwoClassOne ATCO = new AssemblyTwoClassOne();
            Console.WriteLine(ATCO.GetProtectedInternal());
            Console.ReadKey();
        }
    }

}
