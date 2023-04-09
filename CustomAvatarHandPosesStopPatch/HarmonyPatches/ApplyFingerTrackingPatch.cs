using CustomAvatar.Avatar;
using HarmonyLib;

namespace CustomAvatarHandPosesStopPatch.HarmonyPatches
{
    [HarmonyPatch(typeof(AvatarFingerTracking))]
    [HarmonyPatch("ApplyFingerTracking", MethodType.Normal)]
    public class ApplyFingerTrackingPatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
