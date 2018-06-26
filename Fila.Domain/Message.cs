using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Domain
{
   public class Message
    {
        public string Queue { get; set; }
        public string BodyMessage { get; set; }
    }
}
