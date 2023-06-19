namespace InductiveCard
{
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;
    using ServerHandlers = Exiled.Events.Handlers.Server;
    public class Plugin:Plugin<Config>
    {
        private static readonly Plugin SingletonInstance = new Plugin();
        private Plugin() { }
        public static Plugin Instance => SingletonInstance;
        public override string Name { get; } = "InductiveCard";
        public override void OnEnabled()
        {
            EventHandlers eventHandlers = new EventHandlers();
            PlayerHandlers.InteractingDoor += eventHandlers.OnInteractingDoor;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            EventHandlers eventHandlers = new EventHandlers();
            PlayerHandlers.InteractingDoor-=eventHandlers.OnInteractingDoor;
            base.OnDisabled();
        }
    }
}