using Smod2;
using Smod2.Attributes;

namespace PeanutInfection
{
    [PluginDetails(
        author = "LewisTehMinerz",
        name = "Peanut Infection",
        description = "One peanut, loads of people.",
        id = "centurion.gamemode.peanutinfection",
        version = "1.0.0",
        SmodMajor = 3,
        SmodMinor = 0,
        SmodRevision = 0
        )]
    public class PeanutInfection : Plugin
    {
        public override void OnDisable()
        {
            
        }

        public override void OnEnable()
        {
            Info("Embrace the N U T - Enabled.");
        }

        public override void Register()
        {
            AddEventHandlers(new EventHandler(this));
            GamemodeManager.GamemodeManager.RegisterMode(this, "01111111111111111111");
        }
    }
}
