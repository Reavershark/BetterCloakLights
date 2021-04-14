using PulsarPluginLoader;

namespace CloakMod
{
    class CloakMod : PulsarPlugin
    {
        public override string Version => "1.0";

        public override string Author => "Reavershark";

        public override string Name => "BetterCloakLights";

        public override string HarmonyIdentifier()
        {
            return "com.reavershark.cloakmod";
        }
    }
}
