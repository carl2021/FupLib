using System;
using System.IO;
using System.Net.Sockets;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 7000);
            Console.WriteLine("Server Connected");

            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            sw.WriteLine("Connected");

            string message = sr.ReadLine();

            while (message != null)
            {
                Console.WriteLine("Client " + message);
                sw.WriteLine(Console.ReadLine());
            }
        }

        //Opgave 5 Sikker(Secure)

        //Fortrolighed SSL kan sikre ens data, så den ikke kan læses af uautoriseret bruger. Dette kan gennemføres ved hjælp af kryptering af data.
        //Man anvender kryptografisk algoritme og en sikred nøgle, en værdi som kun kendes af en af de 2 bruger som udveksler data.
        // Den data kan kun dekrypteres af selve brugeren som besidder den sikrede nøgle.

        //Kryptering er en teknik til at begrænse adgangen til de data, der transporteres på netværket. 
        //Kryptering koder dataene i en form, der kun kan læses af brugeren, der har "nøglen" til kodningsskemaet. 
        
    }
}
