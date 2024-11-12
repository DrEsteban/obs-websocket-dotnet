using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using OBSWebsocketDotNet.Types;

namespace OBSWebsocketDotNet
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(ObsVideoSettings))]
    public partial class ObsJsonTypeInfo : JsonSerializerContext
    {
    }
}
