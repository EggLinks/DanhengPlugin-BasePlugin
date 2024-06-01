using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhengPlugin.BasePlugin.TutorialData
{
    public class OnPlayerHeartBeat
    {
        public void PlayerHeartBeat(PlayerInstance player)
        {
            Logger.GetByClassName().Info("HeartBeat");
        }
    }
}
