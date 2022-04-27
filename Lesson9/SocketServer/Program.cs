using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of socket class
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Create an object of an IP Address.socket listening on any ip address.
            IPAddress ipaddr = IPAddress.Any;

            // Define IP END POINT
            IPEndPoint ipep = new IPEndPoint(ipaddr, 25000);

            //Bind socket to ip end point.
            try
            {
                listenerSocket.Bind(ipep);
                // Call listen method on the Listener socket object, pass the a number to signify how many
                // clients can wait for a connection while the system is busy handling another connection
                listenerSocket.Listen(5);
                // Call Accept method on the listener socket.
                // Accept is a synchrouous method (Blocking method) will not move forward until operation completed -- Very Bad Method
                Socket client = listenerSocket.Accept();
                //Print out client ip end point
                Console.WriteLine("Client connected: " + client.ToString() + " - Ip End Point: " + client.RemoteEndPoint.ToString());
                

                while (true)
                {
                    ChatClient user = new ChatClient(client);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }

        }
    }
}

//client.
