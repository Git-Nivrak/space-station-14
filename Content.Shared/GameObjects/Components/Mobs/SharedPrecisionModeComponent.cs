using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Shared.GameObjects.Components.Mobs
{
    public abstract class SharedPrecisionModeComponent : Component
    {
        public bool _precision_mode = false;
        public override string Name => "PrecisionMode";


        [Serializable, NetSerializable]
        public class TogglePrecisionMessage : ComponentMessage
        {
            public bool precision_mode;
            public TogglePrecisionMessage(bool _precision_mode)
            {
                Directed = true;
                precision_mode = _precision_mode;
            }
        }
    }
}
