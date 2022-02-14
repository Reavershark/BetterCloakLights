namespace BetterCloakLights
{
    public class Global
    {
        private static float m_Intensity = .15f;
        static public float Intensity
        {
            get
            {
                return m_Intensity;
            }
            set
            {
                m_Intensity = value;
                PLXMLOptionsIO.Instance.CurrentOptions.SetFloatValue("BetterCloakLightIntensity", value);
            }
        }
    }
}
