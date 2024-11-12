using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Communication
{
    /// <summary>
    /// Data required by authentication
    /// </summary>
    public class OBSAuthInfo
    {
        /// <summary>
        /// Authentication challenge
        /// </summary>
        [JsonPropertyName("challenge")]
        public readonly string Challenge;

        /// <summary>
        /// Password salt
        /// </summary>
        [JsonPropertyName("salt")]
        public readonly string PasswordSalt;

        /// <summary>
        /// Builds the object from JSON response body
        /// </summary>
        /// <param name="data">JSON response body as a <see cref="JsonObject"/></param>
        public OBSAuthInfo(JsonObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Default Constructor for deserialization
        /// </summary>
        public OBSAuthInfo() { }
    }
}