﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Tracks status for a source item
    /// </summary>
    public class SourceTracks
    {
        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("1")]
        public bool IsTrack1Active { set; get; }

        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("2")]
        public bool IsTrack2Active { set; get; }

        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("3")]
        public bool IsTrack3Active { set; get; }

        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("4")]
        public bool IsTrack4Active { set; get; }

        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("5")]
        public bool IsTrack5Active { set; get; }

        /// <summary>
        /// Is the track active
        /// </summary>
        [JsonPropertyName("6")]
        public bool IsTrack6Active { set; get; }

        /// <summary>
        /// Builds the object from the JSON data
        /// </summary>
        /// <param name="data">JSON item description as a <see cref="JsonObject"/></param>
        public SourceTracks(JsonObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Default Constructor for deserialization
        /// </summary>
        public SourceTracks() { }
    }
}
