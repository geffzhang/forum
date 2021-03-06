﻿using System;
using ENode.Eventing;

namespace Forum.Domain.Sections
{
    [Serializable]
    public class SectionCreatedEvent : DomainEvent<string>
    {
        public string Name { get; private set; }

        public SectionCreatedEvent(string sectionId, string name)
            : base(sectionId)
        {
            Name = name;
        }
    }
}
