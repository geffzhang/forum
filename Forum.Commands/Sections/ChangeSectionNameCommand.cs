﻿using System;
using ENode.Commanding;

namespace Forum.Commands.Sections
{
    [Serializable]
    public class ChangeSectionNameCommand : AggregateCommand<string>
    {
        public string Name { get; set; }

        public ChangeSectionNameCommand(string id, string name) : base(id)
        {
            Name = name;
        }
    }
}
