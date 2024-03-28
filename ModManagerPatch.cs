namespace DontBlackout;

[HarmonyPatch(typeof(ModManager),nameof(ModManager.LateUpdate))]
public static class ModManagerLateUpdatePatch
{
    public static void Postfix(ModManager __instance)
    {
        __instance.ShowModStamp();
    }
}
