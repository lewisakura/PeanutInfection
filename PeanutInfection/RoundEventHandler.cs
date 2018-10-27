using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.EventSystem.Events;

namespace PeanutInfection
{
    partial class EventHandler : IEventHandlerSetSCPConfig
    {
        public void OnSetSCPConfig(SetSCPConfigEvent ev)
        {
            if (GamemodeManager.GamemodeManager.GetCurrentMode().Equals(plugin))
            {
                ev.Ban049 = true;
                ev.Ban079 = true;
                ev.Ban106 = true;
                ev.Ban939_53 = true;
                ev.Ban939_89 = true;
            }
        }
    }
}
