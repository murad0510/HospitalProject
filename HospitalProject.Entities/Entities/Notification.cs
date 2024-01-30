using HospitalProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Notification
    {
        /// <summary>
        /// Gets or sets the ID of the notification.
        /// </summary>
        public DateTime Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who sent the notification.
        /// </summary>
        public string? SenderId { get; set; }

        /// <summary>
        /// Gets or sets the user who sent the notification.
        /// </summary>
        public virtual CustomIdentityUser? Sender { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who will receive the notification.
        /// </summary>
        public string? ReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the user who will receive the notification.
        /// </summary>
        public virtual CustomIdentityUser? Receiver { get; set; }

        /// <summary>
        /// Gets or sets the message content of the notification.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the notification has been read or not.
        /// </summary>
        public bool IsCheck { get; set; } = false;

        /// <summary>
        /// Gets or sets the date when the notification was sent.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        /// For EFNotificationDal
        public Notification()
        {

        }
    }
}
