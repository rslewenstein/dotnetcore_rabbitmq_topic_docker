using System;
using RabbitMQ.Client;

namespace RabbitMQConsumer
{
    class Program
    {
        private const string UName = "guest";
        private const string PWD = "guest";
        private const string HName = "localhost";
        static void Main(string[] args)
        {
            ConnectionFactory connectionFactory = new ConnectionFactory
            {
                UserName = UName,
                Password = PWD,
                HostName = HName
            };
            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();
            channel.BasicQos(0, 1, false);
            MessageReceiver messageReceiver = new MessageReceiver(channel);
            channel.BasicConsume("topic.bombay.queue", false, messageReceiver);
            Console.ReadLine();
        }
    }
}
