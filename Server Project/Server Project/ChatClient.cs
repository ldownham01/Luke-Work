using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections;

namespace Server_Project
{
    internal class ChatClient
    {
        //contains a list of all the clients
        public static Hashtable AllClients = new Hashtable();

        //information about the client
        private TcpClient _client;
        private string _clientIP;
        private string _clientNick;

        //used for sending/receiving data
        private byte[] data;

        //is the nickname being sent
        private bool ReceiveNick = true;

        public ChatClient(TcpClient client)
        {
            _client = client;
            //---get the client IP address---
            _clientIP = client.Client.RemoteEndPoint.ToString();
            //---add the current client to the hash table---
            AllClients.Add(_clientIP, this);
            //---start reading data from the client in a
            // separate thread---
            data = new byte[_client.ReceiveBufferSize];
            client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(_client.ReceiveBufferSize), ReceiveMessage, null);
        }


    }
}
