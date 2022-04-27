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
    internal class ChatClient
    {
        public static Hashtable AllClients = new Hashtable();

        private Socket _client;
        private string _clientIP;
        // define a buffer as byte array of 128 byte length.
        private byte[] buff = new byte[128];
        // define number of received bytes as an int
        private int numberOfReceivedBytes = 0;

        public ChatClient(Socket client)
        {
            while (true)
            {
                _client = client;
                _clientIP = client.RemoteEndPoint.ToString();

                AllClients.Add(_clientIP, client);

                numberOfReceivedBytes = client.Receive(buff);
                Console.WriteLine("Number of received bytes: " + numberOfReceivedBytes);
                //convert from byte array to ascii, using Encoding.ASCII.GetString
                string receivedText = Encoding.ASCII.GetString(buff, 0, numberOfReceivedBytes);
                //print out text
                Console.WriteLine("Data sent by client is: " + receivedText);
                //Send data back to sender
                client.Send(buff);

                if (receivedText.Length < 1)
                {
                    AllClients.Remove(_clientIP);
                }

                foreach (DictionaryEntry c in AllClients)
                {
                    //---broadcast message to all users---
                    ((Socket)c.Value).Send(buff);
                }
            }
        }

        

    }
}
