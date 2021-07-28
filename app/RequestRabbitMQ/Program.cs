using System;

namespace RequestRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Topicmessages topicm = new Topicmessages();
            topicm.SendMessage();
            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
