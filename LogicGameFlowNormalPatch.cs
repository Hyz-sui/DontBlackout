namespace DontBlackout;

[HarmonyPatch(typeof(LogicGameFlowNormal), nameof(LogicGameFlowNormal.IsGameOverDueToDeath))]
public static class LogicGameFlowNormalIsGameOverDueToDeathPatch
{
    public static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}
