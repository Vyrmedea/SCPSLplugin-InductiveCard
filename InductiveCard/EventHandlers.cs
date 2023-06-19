namespace InductiveCard
{
    using Exiled.API.Features.Items;
    public class EventHandlers
    {
        public void OnInteractingDoor(Exiled.Events.EventArgs.Player.InteractingDoorEventArgs ev)
        {
            if (ev.Player == null) return;
            foreach (var item in ev.Player.Items)
            {
                if (item != null && item is Keycard keycard && ev.Door.RequiredPermissions.CheckPermissions(keycard.Base,ev.Player.ReferenceHub))
                {
                    ev.IsAllowed = true;
                    return;
                }
                else
                {
                    ev.IsAllowed = false;
                }
            }
        }
    }
}
