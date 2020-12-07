using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SERVERAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 15000);
                listener.Start();
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream network = client.GetStream();
                }

                

                Console.ReadKey();
            }
            catch (Exception e)
            {

            }
        }
    }
}
