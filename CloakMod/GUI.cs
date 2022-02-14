using PulsarModLoader.CustomGUI;
using static UnityEngine.GUILayout;

namespace BetterCloakLights
{
    class GUI : ModSettingsMenu
    {
        public override string Name()
        {
            return "BetterCloakLights";
        }

        public override void Draw()
        {
            Label("Intensity");
            Global.Intensity = HorizontalSlider(Global.Intensity, 0f, 1f);
            BeginHorizontal();
            Label(Global.Intensity.ToString());
            EndHorizontal();
            BeginHorizontal();
            if(Button("Mod Default"))
            {
                Global.Intensity = 0.15f;
            }
            if (Button("Vanilla"))
            {
                Global.Intensity = 0.9f;
            }
            EndHorizontal();
        }
    }
}
