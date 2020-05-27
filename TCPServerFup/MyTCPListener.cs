using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TCPServerFup
{
    public class MyTCPListener
    {
        public void Start()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.01");

            TcpListener serverSocket = new TcpListener(ipAddress, 7000);

            serverSocket.Start();
            Console.WriteLine("Server Started");

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSocket = connectionSocket;
                    Console.WriteLine("Server activated");
                    DoClient(tempSocket);
                });
            }
        }

        public static void DoClient(TcpClient socket)
        {
            Stream ns = socket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            string message = sr.ReadLine();
            string answer = "";
            while (message != null && message != "")
            {
                string[] messageArray = message.Split();
                string param = message.Substring(message.IndexOf(' '));
                string command = messageArray[0];

                //switch (command)
                //{
                //    case "GetAll":
                //        sw.WriteLine("Get all received");
                //        sw.WriteLine(JsonConverter.SerializeObject(TransportCalc));
                //        break;
                //    case "Get":
                //        sw.WriteLine("Get recieved");
                //        sw.WriteLine(Tra)
                //}
            }
        }
    }
}
