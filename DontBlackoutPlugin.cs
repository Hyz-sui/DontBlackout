using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace DontBlackout;

[BepInPlugin("com.hyzsui.dontblackout", "DontBlackout", "2024.3.29.0")]
[BepInProcess("Among Us.exe")]
public class DontBlackoutPlugin : BasePlugin
{
    public static DontBlackoutPlugin Instance { get; private set; }

    private readonly Harmony harmony = new("com.hyzsui.dontblackout");

    public override void Load()
    {
        harmony.PatchAll();
        Instance = this;
    }
}
