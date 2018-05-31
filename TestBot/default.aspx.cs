using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestBot
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "4g82T6YExhqPmezoCyHR2jCTi8eJ5slqjM/YOwNwQpoCpsZqaur+PPF29JnySRBAFcZvZXqbj4BYoW0ScLaeX6wqmkA/fb0TOLggUlFtoCJZqzHXnj+ZP6ty9ePrzhjiiBBivZEkylnzGoORgCWHMwdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U5a364222e803128c61c8097c60524655";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}