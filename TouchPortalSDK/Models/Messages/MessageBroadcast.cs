﻿namespace TouchPortalSDK.Models.Messages
{
    public class MessageBroadcast : MessageBase
    {
        /// <summary>
        /// Event that was broadcast, ex. pageChange
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// Name of the page the device is currently on. Ex. "(main)"
        /// </summary>
        public string PageName { get; set; }
    }
}