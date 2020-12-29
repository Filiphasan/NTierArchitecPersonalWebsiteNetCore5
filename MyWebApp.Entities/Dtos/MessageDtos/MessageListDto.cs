using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.MessageDtos
{
    public class MessageListDto : DtoGetBase
    {
        public IList<Message> Messages { get; set; }
    }
}
