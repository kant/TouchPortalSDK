﻿using System;
using TouchPortalSDK.Messages.Items;

namespace TouchPortalSDK.Messages.Commands
{
    public class RemoveStateCommand : ITouchPortalMessage
    {
        public string Type => "removeState";

        public string Id { get; set; }

        public RemoveStateCommand(string stateId)
        {
            if (string.IsNullOrWhiteSpace(stateId))
                throw new ArgumentNullException(nameof(stateId));

            Id = stateId;
        }

        public Identifier GetIdentifier()
            => new Identifier(Type, Id, default);
    }
}
