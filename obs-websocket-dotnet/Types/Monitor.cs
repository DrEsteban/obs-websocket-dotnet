﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Information on a connected Monitor
    /// </summary>
    public class Monitor
    {
        /// <summary>
        /// Monitor height (px)
        /// </summary>
        [JsonPropertyName("monitorHeight")]
        public int Height { get; set; }

        /// <summary>
        /// Monitor width (px)
        /// </summary>
        [JsonPropertyName("monitorWidth")]
        public int Width { get; set; }

        /// <summary>
        /// Monitor Name
        /// </summary>
        [JsonPropertyName("monitorName")]
        public string Name { get; set; }

        /// <summary>
        /// Monitor Index
        /// </summary>
        [JsonPropertyName("monitorIndex")]
        public int Index { get; set; }

        /// <summary>
        /// Monitor Position X
        /// </summary>
        [JsonPropertyName("monitorPositionX")]
        public int PositionX { get; set; }

        /// <summary>
        /// Monitor Position Y
        /// </summary>
        [JsonPropertyName("monitorPositionY")]
        public int PositionY { get; set; }

        /// <summary>
        /// Constructor to auto populate
        /// </summary>
        /// <param name="data"></param>
        public Monitor (JsonObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Monitor() { }
    }
}
