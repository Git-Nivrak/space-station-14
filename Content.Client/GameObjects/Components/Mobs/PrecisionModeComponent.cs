using Content.Shared.GameObjects.Components.Mobs;
using Content.Shared.Input;
using Robust.Shared.GameObjects;
using Robust.Shared.Input.Binding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Client.GameObjects.Components.Mobs
{
    [RegisterComponent]
    [ComponentReference(typeof(SharedPrecisionModeComponent))]
    public sealed class PrecisionModeComponent : SharedPrecisionModeComponent
    {
        public void TogglePrecision()
        {
            _precision_mode = !_precision_mode;
            Owner.SendNetworkMessage(this, new TogglePrecisionMessage(_precision_mode));
        }

        public override void Initialize()
        {
            base.Initialize();

        }
    }
}
