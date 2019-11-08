﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Linq;
using System.Text;

namespace TopicConsumer
{
    class Program
    {
        //Command line arg eg: dotnet TopicSubscriber <queuename> <key-pattern>
        //eg: 
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Invalid number of arguments");
                return;
            }           

            var factory = new ConnectionFactory() { HostName = "localhost" };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchange: "topic-exch",
              type: ExchangeType.Topic,
              durable: false,
              autoDelete: false,
              arguments: null);

            channel.QueueDeclare(args[0], durable: false, exclusive: false, autoDelete: false);
            var keys = args.Skip(1).Take(args.Length - 1);
            foreach (var key in keys)
            {
                channel.QueueBind(args[0], "topic-exch", key, null);
            }

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (ch, eq) =>
            {
                var message = Encoding.UTF8.GetString(eq.Body);
                Console.WriteLine($"Message received:{message}");
            };
            channel.BasicConsume(args[0], true, consumer);

            Console.WriteLine("Waiting for message... Press ENTER to exit");
            Console.ReadLine();

            channel.Dispose();
            connection.Dispose();
        }
    }
}
