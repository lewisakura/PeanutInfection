using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;

namespace PeanutInfection
{
    partial class EventHandler : IEventHandlerPlayerDie
    {
        public void OnPlayerDie(PlayerDeathEvent ev)
        {
            if (GamemodeManager.GamemodeManager.GetCurrentMode().Equals(plugin))
            {
                if (ev.Killer.TeamRole.Role == Role.SCP_173)
                {
                    ev.Player.ChangeRole(Role.SCP_173);
                }
            }
        }
    }
}
