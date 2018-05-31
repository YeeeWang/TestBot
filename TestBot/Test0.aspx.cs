using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestBot
{
    public partial class Test0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("4g82T6YExhqPmezoCyHR2jCTi8eJ5slqjM/YOwNwQpoCpsZqaur+PPF29JnySRBAFcZvZXqbj4BYoW0ScLaeX6wqmkA/fb0TOLggUlFtoCJZqzHXnj+ZP6ty9ePrzhjiiBBivZEkylnzGoORgCWHMwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U5a364222e803128c61c8097c60524655", "Hello");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("4g82T6YExhqPmezoCyHR2jCTi8eJ5slqjM/YOwNwQpoCpsZqaur+PPF29JnySRBAFcZvZXqbj4BYoW0ScLaeX6wqmkA/fb0TOLggUlFtoCJZqzHXnj+ZP6ty9ePrzhjiiBBivZEkylnzGoORgCWHMwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U5a364222e803128c61c8097c60524655", 1,15);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("4g82T6YExhqPmezoCyHR2jCTi8eJ5slqjM/YOwNwQpoCpsZqaur+PPF29JnySRBAFcZvZXqbj4BYoW0ScLaeX6wqmkA/fb0TOLggUlFtoCJZqzHXnj+ZP6ty9ePrzhjiiBBivZEkylnzGoORgCWHMwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U5a364222e803128c61c8097c60524655", new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_5FS-O5Wirurj7a29CBNtbCZ2Hd44XeuNnA0NV6LUBWA3o5sr"));
        }
    }
}