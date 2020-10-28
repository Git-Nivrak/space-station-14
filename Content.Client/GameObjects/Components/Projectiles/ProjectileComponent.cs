#nullable enable
using Content.Shared.GameObjects.Components.Projectiles;
using Content.Shared.Input;
using Robust.Client.Interfaces.Input;
using Robust.Shared.GameObjects;
using Robust.Shared.Input.Binding;
using Robust.Shared.Interfaces.GameObjects;
using Robust.Shared.IoC;
using Robust.Shared.Serialization;
using System;

namespace Content.Client.GameObjects.Components.Projectiles
{
    [RegisterComponent]
    public class ProjectileComponent : SharedProjectileComponent
    {
        protected override EntityUid Shooter => _shooter;
        private EntityUid _shooter;

        public override void HandleComponentState(ComponentState? curState, ComponentState? nextState)
        {
            if (curState is ProjectileComponentState compState)
            {
                _shooter = compState.Shooter;
                IgnoreShooter = compState.IgnoreShooter;
            }
        }

    }
}
