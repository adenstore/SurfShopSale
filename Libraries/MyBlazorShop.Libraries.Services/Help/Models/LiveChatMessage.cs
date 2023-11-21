using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorShop.Libraries.Services.Help.Models
{
    public class LiveChatMessage
    {
        public string Message { get; set; }
        public LiveChatEnum Type { get; set; }

        public string TypeName
        {
            get
            {
                switch (Type)
                {
                    case LiveChatEnum.SENT:
                        return "sent";
                    case LiveChatEnum.RECEIVED:
                        return "recieved";
                }
                return "";
            }
        }
        public LiveChatMessage(string message, LiveChatEnum lce)
        {
            Message = message;
            Type = lce;
        }
    }
}
