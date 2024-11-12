using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemListReindexed"/>
    /// </summary>
    public class SceneItemListReindexedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the scene where items where reordered
        /// </summary>
        public string SceneName { get; } 

        /// <summary>
        /// List of all scene items as JsonObject
        /// </summary>
        public List<JsonObject> SceneItems { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneName">The scene name</param>
        /// <param name="sceneItems">The scene item data as a colleciton of JsonObjects</param>
        public SceneItemListReindexedEventArgs(string sceneName, List<JsonObject> sceneItems)
        {
            SceneName = sceneName;
            SceneItems = sceneItems;
        }
    }
}