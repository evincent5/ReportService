using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.HelloClient host = new ServiceReference1.HelloClient();
            host.Open();
            Console.WriteLine("Host started @ " + DateTime.Now.ToString());

            //var msg = proxy.GetData(101);
            //Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
