using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Application.Messages.Models
{
    public class MessageModel
    {
        public string Queue { get; set; }
        public JObject BodyMessage { get; set; }
    }
}
