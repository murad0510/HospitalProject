using HospitalProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Message
    {
        /// <summary>
        /// Gets or sets the ID of the message.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the date when the message was sent.
        /// </summary>
        public DateTime SentDate { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Gets or sets the ID of the chat associated with the message.
        /// </summary>
        public string? ChatId { get; set; }

        /// <summary>
        /// Gets or sets the chat associated with the message.
        /// </summary>
        public Chat? Chat { get; set; }

        /// <summary>
        /// Gets or sets the ID of the sender user associated with the message.
        /// </summary>
        public string? SenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the sender user associated with the message.
        /// </summary>
        public CustomIdentityUser? SenderUser { get; set; }

        /// <summary>
        /// Gets or sets the ID of the receiver user associated with the message.
        /// </summary>
        public string? ReceiverUserId { get; set; }

        /// <summary>
        /// Gets or sets the receiver user associated with the message.
        /// </summary>
        public CustomIdentityUser? ReceiverUser { get; set; }
    }
}
