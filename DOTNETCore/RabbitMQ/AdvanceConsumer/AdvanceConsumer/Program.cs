using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Queue Name" + args[0]);

            var factory = new ConnectionFactory() { HostName = "localhost" };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchange: "demo-exch",
              type: ExchangeType.Fanout,
              durable: false,
              autoDelete: false,
              arguments: null);

            var arguments = new Dictionary<string, object>()
            {
                {"x-message-ttl", 60000 }, //TTL for the queue message (all message)
                {"x-expires", 30*60*1000 } //Queue expiry after idle timeout, in millisecond
            };

            channel.QueueDeclare("demoq", durable: false, exclusive: false, autoDelete: false, arguments: arguments);
            channel.QueueBind("demoq", "demo-exch", "", null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (ch, eq) =>
            {
                var message = Encoding.UTF8.GetString(eq.Body);
                Console.WriteLine($"Message received:{message}");
                channel.BasicAck(eq.DeliveryTag, multiple: false); //Explicit acknoledgement
            };
            channel.BasicConsume(queue: "demoq", autoAck: false, consumer: consumer); //disable auto ack

            Console.WriteLine("Waiting for message... Press ENTER to exit");
            Console.ReadLine();

            channel.Dispose();
            connection.Dispose();
        }
    }
}
