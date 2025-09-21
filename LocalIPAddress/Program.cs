
// Amir Moeini Rad
// April 26, 2025

// Main Concept: Retrieving the local machine's IP addresses using System.Net namespace.
// Classes used in System: Dns, IPHostEntry, IPAddress.


using System.Net;

namespace LocalIPAddress
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Local IP Addresses...");
            Console.WriteLine("---------------------\n");


            // 'Dns' class: provides domain name resolution functionality.
            // 'GetHostName()': gets the host name of the local computer.
            string hostName = Dns.GetHostName();
            Console.WriteLine("Local computer's host name: {0}\n", hostName);

            // 'IPHostEntry' class: provides information about a host address.
            // 'GetHostEntry("string")': resolves a host name or IP address into an IPHostEntry object.
            // 'IPHostEntry.AddressList': gets or sets a list of IP addresses associated with a host.
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            foreach (IPAddress ip in hostEntry.AddressList)
            {
                Console.WriteLine($"Local IP Address: {ip}");
            }


            Console.WriteLine("\nDone.");
        }
    }
}

