using HospitalProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Chat
    {
        /// <summary>
        /// Gets or sets the ID of the chat.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the sender user associated with the chat.
        /// </summary>
        public string? SenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the sender user associated with the chat.
        /// </summary>
        public CustomIdentityUser? SenderUser { get; set; }

        /// <summary>
        /// Gets or sets the ID of the receiver user associated with the chat.
        /// </summary>
        public string? ReceiverUserId { get; set; }

        /// <summary>
        /// Gets or sets the receiver user associated with the chat.
        /// </summary>
        public CustomIdentityUser? ReceiverUser { get; set; }

        /// <summary>
        /// Gets or sets the collection of messages associated with the chat.
        /// </summary>
        public virtual IEnumerable<Message>? Messages { get; set; } = new List<Message>();
    }
}
