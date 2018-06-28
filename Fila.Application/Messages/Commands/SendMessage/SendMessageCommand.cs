using Fila.Application.Interfaces;
using Fila.Application.Messages.Models;
using Fila.Common.Serializations;
using Fila.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Messages.Commands.SendMessage
{
    public class SendMessageCommand : ISendMessageCommand
    {
        private readonly IMessageQueueingService _messsageQueuingService;
        private readonly ISerializationService _serializationService;
        public SendMessageCommand(IMessageQueueingService messageQueueingService,
            ISerializationService serializationService)
        {
            _messsageQueuingService = messageQueueingService;
            _serializationService = serializationService;
        }

        public void Execute(MessageModel messageModel)
        {
            Message message = new Message
            {
                Queue = messageModel.Queue,
                BodyMessage = messageModel.BodyMessage.ToString()
            };

            _messsageQueuingService.Queue = message.Queue;
            _messsageQueuingService.Connect();
            _messsageQueuingService.SendMessage(_serializationService.ToByteArray(message.BodyMessage));
            _messsageQueuingService.Disconnect();
        }
    }
}
