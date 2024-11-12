﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Version info of the plugin, the API and OBS Studio
    /// </summary>
    public class ObsVersion
    {
        /// <summary>
        /// obs-websocket plugin version
        /// </summary>
        [JsonPropertyName("obsWebSocketVersion")]
        public string PluginVersion { get; internal set; }

        /// <summary>
        /// OBS Studio version
        /// </summary>
        [JsonPropertyName("obsVersion")]
        public string OBSStudioVersion { get; internal set; }

        /// <summary>
        /// OBSRemote compatible API version.Fixed to 1.1 for retrocompatibility.
        /// </summary>
        [JsonPropertyName("rpcVersion")]
        public double Version { internal set; get; }

        /// <summary>
        /// List of available request types, formatted as a comma-separated list string (e.g. : "Method1,Method2,Method3").
        /// </summary>
        [JsonPropertyName("availableRequests")]
        public List<string> AvailableRequests { get; internal set; }

        /// <summary>
        /// Image formats available in `GetSourceScreenshot` and `SaveSourceScreenshot` requests.
        /// </summary>
        [JsonPropertyName("supportedImageFormats")]
        public List<string> SupportedImageFormats { get; internal set; }

        /// <summary>
        /// Name of the platform. Usually `windows`, `macos`, or `ubuntu` (linux flavor). Not guaranteed to be any of those
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; internal set; }

        /// <summary>
        /// Description of the platform, like `Windows 10 (10.0)`
        /// </summary>
        [JsonPropertyName("platformDescription")]
        public string PlatformDescription { get; internal set; }

        /// <summary>
        /// Builds the object from the JSON response body
        /// </summary>
        /// <param name="data">JSON response body as a <see cref="JsonObject"/></param>
        public ObsVersion(JsonObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Empty constructor for jsonconvert
        /// </summary>
        public ObsVersion() { }

    }
}