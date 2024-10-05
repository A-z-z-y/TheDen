using Robust.Shared.GameStates;

namespace Content.Shared.Shadowkin
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class EtherealComponent : Component
    {
        /// <summary>
        /// Does the Ent, Dark lights around it?
        /// </summary>
        [DataField]
        public bool Darken = false;

        /// <summary>
        /// Range of the Darken Effect.
        /// </summary>
        [DataField]
        public float DarkenRange = 5;

        /// <summary>
        /// Darken Effect Rate.
        /// </summary>
        [DataField]
        public float DarkenRate = 0.084f;

        public List<EntityUid> DarkenedLights = new();

        public float DarkenAccumulator;

        public List<string> SuppressedFactions = new();
    }
}