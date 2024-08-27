using DanhengPlugin.BasePlugin.TutorialData;
using EggLink.DanhengServer.GameServer.Plugin.Constructor;
using EggLink.DanhengServer.GameServer.Plugin.Event;
using EggLink.DanhengServer.Util;

namespace DanhengPlugin.BasePlugin;

[PluginInfo("BasePlugin", "The base plugin of DanhengServer.", "1.0")]
public class DanhengBasePlugin : IPlugin
{
    private readonly Logger logger = new("BasePlugin");

    public void OnLoad()
    {
        logger.Info("BasePlugin loaded");

        PluginEvent.OnPlayerHeartBeat += new OnPlayerHeartBeat().PlayerHeartBeat;
    }

    public void OnUnload()
    {
        logger.Info("BasePlugin unloaded");
    }
}