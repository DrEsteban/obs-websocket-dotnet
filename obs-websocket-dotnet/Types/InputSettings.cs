using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Settings for a source item
    /// </summary>
    public class InputSettings : Input
    {
        /// <summary>
        /// Settings for the source
        /// </summary>
        [JsonPropertyName("inputSettings")]
        public JsonObject Settings { set; get; }

        /// <summary>
        /// Builds the object from the JSON data
        /// </summary>
        /// <param name="data">JSON item description as a <see cref="JsonObject"/></param>
        public InputSettings(JsonObject data) : base(data)
        {
            this.Settings = data["inputSettings"].AsObject();
        }

        /// <summary>
        /// Default Constructor for deserialization
        /// </summary>
        public InputSettings() { }
    }
}