using Fila.Application.Interfaces;
using Fila.Application.Settings;
using Fila.Common.Serializations;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Infrastructure
{
  public class MessageQueueingService : IMessageQueueingService
    {
        public string Queue { get; set; }
        private IConnection connection;
        private IModel channel;
        private readonly IOptions<MessageQueueingSettings> _messageQueueingSettings;

        public MessageQueueingService(IOptions<MessageQueueingSettings> messageQueueingSettings)
        {
            _messageQueueingSettings = messageQueueingSettings;
        }

        public void Connect()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = _messageQueueingSettings.Value.HostName
            };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(Queue, false, false, false, null);
        }

        public void Disconnect()
        {
            channel = null;

            if (connection.IsOpen)
            {
                connection.Close();
            }

            connection.Dispose();
            connection = null;
        }

        public void SendMessage(byte[] message)
        {
            channel.BasicPublish(string.Empty, Queue, null, message);
        }
    }
}
