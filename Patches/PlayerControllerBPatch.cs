using GameNetcodeStuff;
using HarmonyLib;

namespace Pikmin2.Patches
{
        [HarmonyPatch(typeof(PlayerControllerB))]
        public class PlayerControllerBPatch
        {
            
            [HarmonyPatch("Update")]
            [HarmonyPostfix] 
            static void PatchUpdate(ref float ___sprintMeter)
            {  
               ___sprintMeter = 1f; 
            }

        }
}