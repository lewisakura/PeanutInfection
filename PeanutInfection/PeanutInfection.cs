using Smod2;
using Smod2.Attributes;
using Smod2.Config;

namespace PeanutInfection
{
    [PluginDetails(
        author = "LewisTehMinerz",
        name = "Peanut Infection",
        description = "Standard SCP:SL, except for the fact that Peanut is infecting everyone!",
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
            AddConfig(new ConfigSetting("peanut_infection_respawn_time", 1, SettingType.FLOAT, true, "The amount of time it takes for a victim of Peanut to respawn as Peanut, in seconds. This is a float, so you can use decimals."));
            AddConfig(new ConfigSetting("peanut_infection_spawn_corpses", false, SettingType.BOOL, true, "Whether or not to spawn corpses. Only takes effect if the victim was killed by a Peanut."));
            AddEventHandlers(new EventHandler(this));
            GamemodeManager.GamemodeManager.RegisterMode(this, "-1");
        }
    }
}
