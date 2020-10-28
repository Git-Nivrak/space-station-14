using System;
using System.Collections.Generic;
using System.Text;
using Content.Shared.GameObjects.Components.Mobs;
using Robust.Shared.GameObjects;
using Robust.Shared.Interfaces.Network;
using Robust.Shared.Log;
using Robust.Shared.Players;

namespace Content.Server.GameObjects.Components.Mobs
{
    [RegisterComponent]
    [ComponentReference(typeof(SharedPrecisionModeComponent))]
    public sealed class PrecisionModeComponent : SharedPrecisionModeComponent
    {
        public override void HandleNetworkMessage(ComponentMessage message, INetChannel netChannel, ICommonSession session = null)
        {
            base.HandleNetworkMessage(message, netChannel, session);

            switch (message)
            {
                case TogglePrecisionMessage msg:
                    _precision_mode = msg.precision_mode;
                    Logger.Info("HAHA NETWORK MESSAGE WORKS WEEEE " + _precision_mode.ToString());
                    break;
            }
            
            
        }
    }
}
