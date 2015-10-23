using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingEnum.Common;
using BreakingEnum.Helper;

namespace BreakingEnum.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application: {0}", typeof(Program).Assembly.GetName().Version);
            Console.WriteLine("Helper: {0}", typeof(StatusHelper).Assembly.GetName().Version);
            Console.WriteLine("Common: {0}", typeof(StatusEnum).Assembly.GetName().Version);

            var status = StatusHelper.IsActive("Active");
            if (status)
            {
                Console.WriteLine("Status is active");
            }
            else
            {
                Console.WriteLine("Status is Disabled");
            }
        }
    }
}
