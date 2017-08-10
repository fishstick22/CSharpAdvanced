using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



            Console.WriteLine(date2);
        }
    }
}
