using Rajasekhar.TestService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Service1 client = new Service1();

            // Use the 'client' variable to call operations on the service.

            // Always close the client.
            var test= client.GetAllJsonData();
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
