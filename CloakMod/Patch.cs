﻿using HarmonyLib;
using PulsarPluginLoader.Patches;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CloakMod
{
    public class Patch
    {
        [HarmonyPatch(typeof(PLShipInfo), "Update")]
        internal class CloakIntensityPatch
        {
            private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                List<CodeInstruction> TargetSequence = new List<CodeInstruction>()
                {
                    new CodeInstruction(OpCodes.Ldc_R4, (float)0.9),
                    new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(UnityEngine.Time), "get_time"))
                };
                List<CodeInstruction> InjectedSequence = new List<CodeInstruction>()
                {
                    new CodeInstruction(OpCodes.Ldc_R4, (float)0.15),
                    new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(UnityEngine.Time), "get_time"))
                };
                return HarmonyHelpers.PatchBySequence(instructions, TargetSequence, InjectedSequence, HarmonyHelpers.PatchMode.REPLACE);
            }
        }
    }
}
