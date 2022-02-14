using PulsarModLoader;

namespace BetterCloakLights
{
    class CloakMod : PulsarMod
    {
        public CloakMod()
        {
            Global.Intensity = PLXMLOptionsIO.Instance.CurrentOptions.GetFloatValue("BetterCloakLightIntensity");
        }

        public override string Version => "1.1";

        public override string Author => "Reavershark";

        public override string Name => "BetterCloakLights";

        public override string HarmonyIdentifier()
        {
            return "com.reavershark.cloakmod";
        }
    }
}
