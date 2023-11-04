namespace InductiveCard
{
    public class EventHandlers
    {
        public void OnInteractingDoor(Exiled.Events.EventArgs.Player.InteractingDoorEventArgs ev)
        {
            if (ev.Player == null) return;
            foreach (var item in ev.Player.Items)
            {
                if (item != null && ev.Door.RequiredPermissions.CheckPermissions(item.Base,ev.Player.ReferenceHub))
                {
                    ev.IsAllowed = true;
                    return;
                }
            }
        }
    }
}
