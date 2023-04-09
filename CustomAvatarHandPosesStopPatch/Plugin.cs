using IPA;
using IPALogger = IPA.Logging.Logger;
using HarmonyLib;
using System.Reflection;

namespace CustomAvatarHandPosesStopPatch
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        /// <summary>
        /// BSIPA を通してログメッセージを送信する場合に使用します。
        /// </summary>
        internal static IPALogger Log { get; private set; }
        private Harmony _harmony;
        public const string HARMONY_ID = "com.github.rynan4818.CustomAvatarHandPosesStopPatch";

        [Init]
        public Plugin(IPALogger logger)
        {
            Instance = this;
            Log = logger;
            this._harmony = new Harmony(HARMONY_ID);
        }

        [OnStart]
        public void OnApplicationStart()
        {
            Plugin.Log.Info("OnApplicationStart");
            this._harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        [OnExit]
        public void OnApplicationQuit()
        {
            this._harmony.UnpatchSelf();
        }

    }
}
