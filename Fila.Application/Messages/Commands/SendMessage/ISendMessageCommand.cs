using Fila.Application.Messages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Messages.Commands.SendMessage
{
   public interface ISendMessageCommand
    {
        void Execute(MessageModel message);
    }
}
