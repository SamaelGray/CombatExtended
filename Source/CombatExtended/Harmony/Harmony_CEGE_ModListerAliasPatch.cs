using HarmonyLib;
using Verse;

namespace CombatExtended.HarmonyCE
{
    [HarmonyPatch(typeof(ModLister), nameof(ModLister.HasActiveModWithName))]
    public static class Harmony_ModListerAliasPatch
    {
        public static void Postfix(string name, ref bool __result)
        {
            if (__result == false && name == "Combat Extended")
            {
                __result = true;
            }
        }
    }
}
