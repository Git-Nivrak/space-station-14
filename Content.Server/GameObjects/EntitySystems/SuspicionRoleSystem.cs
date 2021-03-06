﻿using System.Collections.Generic;
using Content.Server.GameObjects.Components.Suspicion;
using JetBrains.Annotations;
using Robust.Shared.GameObjects.Systems;

namespace Content.Server.GameObjects.EntitySystems
{
    [UsedImplicitly]
    public class SuspicionRoleSystem : EntitySystem
    {
        private readonly HashSet<SuspicionRoleComponent> _traitors = new HashSet<SuspicionRoleComponent>();

        public IReadOnlyCollection<SuspicionRoleComponent> Traitors => _traitors;

        public void AddTraitor(SuspicionRoleComponent role)
        {
            if (!_traitors.Add(role))
            {
                return;
            }

            foreach (var traitor in _traitors)
            {
                traitor.AddAlly(role);
            }

            role.SetAllies(_traitors);
        }

        public void RemoveTraitor(SuspicionRoleComponent role)
        {
            if (!_traitors.Remove(role))
            {
                return;
            }

            foreach (var traitor in _traitors)
            {
                traitor.RemoveAlly(role);
            }

            role.ClearAllies();
        }

        public override void Shutdown()
        {
            _traitors.Clear();
            base.Shutdown();
        }
    }
}
