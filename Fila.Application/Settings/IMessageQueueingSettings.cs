using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Settings
{
   public interface IMessageQueueingSettings 
    {
      string HostName { get; set; }
    }
}
