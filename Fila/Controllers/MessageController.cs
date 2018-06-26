using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fila.Application.Messages.Commands.SendMessage;
using Fila.Application.Messages.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fila.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly ISendMessageCommand _sendMessageCommand;

        public MessageController(ISendMessageCommand sendMessageCommand)
        {
            _sendMessageCommand = sendMessageCommand;
        }

        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            _sendMessageCommand.Execute(message);
        }
    }
}