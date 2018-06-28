using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Interfaces
{
   public interface IMessageQueueingService 
    {
        string Queue { get; set; }

        void Connect();
        void Disconnect();
        void SendMessage(byte[] message);
    }
}
