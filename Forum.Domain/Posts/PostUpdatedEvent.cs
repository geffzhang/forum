﻿using System;
using ENode.Eventing;

namespace Forum.Domain.Posts
{
    /// <summary>表示帖子已修改的领域事件
    /// </summary>
    [Serializable]
    public class PostUpdatedEvent : DomainEvent<string>
    {
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public PostUpdatedEvent(string postId, string subject, string body) : base(postId)
        {
            Subject = subject;
            Body = body;
        }
    }
}
