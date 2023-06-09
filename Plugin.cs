using BepInEx;
using UnityEngine;


namespace TalesOfTheNeonSea_ConsoleCommands
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        private void Update()
        {
            // Plugin update logic
            if (Input.GetKeyDown(KeyCode.Return))
            {
                for (int i = 0; i < 69; i++)
                {
                    AchievementManager.Instance.UnlockAchievement(i);
                }
            }


        }
    }
}
