namespace DontBlackout;

[HarmonyPatch(typeof(LogicGameFlowNormal), nameof(LogicGameFlowNormal.IsGameOverDueToDeath))]
public static class LogicGameFlowNorNormalIsGameOverDueToDeathPatch
{
    public static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}
