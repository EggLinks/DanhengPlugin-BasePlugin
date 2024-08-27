using EggLink.DanhengServer.GameServer.Game.Player;
using EggLink.DanhengServer.Util;

namespace DanhengPlugin.BasePlugin.TutorialData;

public class OnPlayerHeartBeat
{
    public void PlayerHeartBeat(PlayerInstance player)
    {
        Logger.GetByClassName().Info("HeartBeat");
    }
}