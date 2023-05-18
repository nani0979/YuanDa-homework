using System;
using System.Net.Sockets;
using System.Net;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace YuanDa_homwork.Modules
{
    internal class SocketClient
    {
        public static SocketClient Instance = new SocketClient();

        public string Ip
        {
            get { return Ip; }
            set
            {
                if (isIPv4Format(value))
                {
                    Ip = value;
                }
                else
                {
                    throw new ArgumentException("Invalid IP address");
                }
            }
        }
        public int Port { get; set; }
        private Socket _socket;

        public SocketClient()
        {
            this.Ip = "127.0.0.1";
            this.Port = 8080;
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }



        public bool Connect()
        {
            Console.WriteLine(">> SocketClient :: Connect");
            Console.WriteLine("<< SocketClient :: Connect");
            return true;
        }

        public void Send(byte[] data)
        {
            Console.WriteLine("SocketClient Send");
        }

        public void Receive()
        {
            Console.WriteLine("SocketClient Receive");
        }

        public void Close()
        {
            Console.WriteLine("SocketClient Close");
            _socket.Close();
        }

        private bool isIPv4Format(string ipAddress)
        {
            Regex validateIPv4Regex = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return validateIPv4Regex.IsMatch(ipAddress);
        }
    }
}
