using System;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for unsupported events
    /// </summary>
    public class UnsupportedEventArgs : EventArgs
    {
        /// <summary>
        /// The type of the event
        /// </summary>
        public string EventType { get; }
        /// <summary>
        /// The body of the event
        /// </summary>
        public JsonObject Body { get; }

        /// <summary>
        /// Event args for unsupported events
        /// </summary>
        public UnsupportedEventArgs(string eventType, JsonObject body)
        {
            EventType = eventType;
            Body = body;
        }
    }
}
