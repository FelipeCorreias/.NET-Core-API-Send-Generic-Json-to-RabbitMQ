using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Settings
{
    public class MessageQueueingSettings : IMessageQueueingSettings
    {
        public string HostName { get; set; }
    }
}
