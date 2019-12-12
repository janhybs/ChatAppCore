using System.Collections.Generic;

namespace ChatAppCore.Entities
{
    public class ChatGroup
    {
        public string Name { get; set; }
        public IEnumerable<ChatUser> Users { get; set; }

    }
}