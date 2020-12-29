using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.MessageDtos
{
    public class MessageDto : DtoGetBase
    {
        public Message Messagee { get; set; }
    }
}
