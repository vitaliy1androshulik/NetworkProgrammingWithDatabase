using System.Net.Sockets;
using System.Net;
using Server.Entities;

namespace Server
{
    public class ChatServer
    {
        const short port = 4040;
        const string serverAddress = "127.0.0.1";

        TcpListener server = null;
        public ChatServer()
        {
            server = new TcpListener(new IPEndPoint(IPAddress.Parse(serverAddress), port));
        }
        public void Start()
        {
            server.Start();
            Console.WriteLine("Waiting for connection!....");
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Connected!!!");
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            CarDBContext context = new CarDBContext();
            while (true)
            {
                string message = sr.ReadLine();
                if (message.Count()>2)
                {
                    var Region = context.CarLetters
                                    .Where(f => f.Region == message);
                    foreach (var item in Region)
                    {
                        sw.WriteLine(item.Code);
                    }
                }
                else if(message.Count() == 2)
                {
                    var Code = context.CarLetters
                                    .Where(f => f.Code == message);

                    foreach (var item in Code)
                    {
                        sw.WriteLine(item.Region);
                    }
                }
                sw.Flush();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatServer server = new ChatServer();
            server.Start();
        }
    }
}
