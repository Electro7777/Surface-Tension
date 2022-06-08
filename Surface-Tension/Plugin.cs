using Exiled.API.Features;
using System;
using Surface_Tension.Configs;
using Server = Exiled.Events.Handlers.Server;
using Warhead = Exiled.Events.Handlers.Warhead;

namespace Surface_Tension
{
    public class Plugin : Plugin<BaseConfig>
    {
        public static Plugin Instance;
        private EventHandler events;

        public override string Name => "SurfaceTension";
        public override string Author => "Holmium67, Heisenberg3666, updated by Electro7777";
        public override Version Version => new Version(3, 0, 0, 0);
        public override Version RequiredExiledVersion => new Version(5, 2, 1);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            events = new EventHandler();
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            events = null;
            Instance = null;
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            Server.RoundStarted += events.OnRoundStart;
            Server.EndingRound += events.OnRoundEnd;
            Warhead.Detonated += events.OnWarheadDetonation;
        }

        public void UnregisterEvents()
        {
            Server.RoundStarted -= events.OnRoundStart;
            Server.EndingRound -= events.OnRoundEnd;
            Warhead.Detonated -= events.OnWarheadDetonation;
        }
    }
}
