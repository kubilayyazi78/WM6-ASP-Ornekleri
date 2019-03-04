using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SingalRApp
{
    public class Sohbet : Hub
    {
       public void HerkeseGonder (string gonderen , string mesaj)
        {
            Clients.All.herkeseGonder(gonderen, mesaj);
        }
    }
}