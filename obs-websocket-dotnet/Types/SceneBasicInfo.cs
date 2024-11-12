﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Response from <see cref="OBSWebsocket.GetSceneList"/>
    /// </summary>
    public class SceneBasicInfo
    {
        /// <summary>
        /// Name of scene
        /// </summary>
        [JsonPropertyName("sceneName")]
        public string Name { set; get; }

        /// <summary>
        /// Index of scene
        /// </summary>
        [JsonPropertyName("sceneIndex")]
        public string Index { set; get; }
    }
}
