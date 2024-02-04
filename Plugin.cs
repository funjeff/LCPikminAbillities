
using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using Pikmin2.Patches;

namespace Pikmin2
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        private readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");


            harmony.PatchAll(typeof(PlayerControllerBPatch));
            

        }
    }

    // [HarmonyPatch(typeof(PlayerControllerB))]     
    // internal class PlayerControllerBPatch
    // {   
    //         [HarmonyPatch("Update")]
    //         [HarmonyPostfix] 
    //         static void patchUpdate(ref float ___sprintMeter)
    //         {  
    //            ___sprintMeter = 1f; 
    //         }

    //     }
}
