using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            int protocolIndex = url.IndexOf("://");
            string protocol = url.Substring(0, protocolIndex);
            int resourceIndex = url.IndexOf('/', protocolIndex + 3);
            string server = url.Substring(protocolIndex + 3, resourceIndex - protocolIndex - 3);
            string resource = url.Substring(resourceIndex, url.Length - resourceIndex);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
