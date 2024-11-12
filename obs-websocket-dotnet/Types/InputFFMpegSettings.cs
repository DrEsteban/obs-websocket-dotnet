﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Input class dedicated for the ffmpeg_source input kind.
    /// Usage: InputFFMpegSettings.FromInputSettings(InputSettings)
    /// </summary>
    public class InputFFMpegSettings : Input
    {
        private const string SUPPORTED_INPUT_KIND = "ffmpeg_source";

        /// <summary>
        /// Buffering MB
        /// </summary>
        [JsonPropertyName("buffering_mb")]
        public int BufferingMB { get; set; } = 2;

        /// <summary>
        /// Clear window when media ends
        /// </summary>
        [JsonPropertyName("clear_on_media_end")]
        public bool ClearOnMediaEnd { get; set; } = true;

        /// <summary>
        /// Close when inactive
        /// </summary>
        [JsonPropertyName("close_when_inactive")]
        public bool CloseWhenInactive { get; set; } = false;

        /// <summary>
        /// Color Range
        /// </summary>
        [JsonPropertyName("color_range")]
        public int ColorRange { get; set; } = 0;

        /// <summary>
        /// HW Decoder
        /// </summary>
        [JsonPropertyName("hw_decode")]
        public bool HWDecode { get; set; } = false;

        /// <summary>
        /// Is Local file
        /// </summary>
        [JsonPropertyName("is_local_file")]
        public bool IsLocalFile { get; set; } = true;

        /// <summary>
        /// Local filename
        /// </summary>
        [JsonPropertyName("local_file")]
        public string LocalFile { get; set; }

        /// <summary>
        /// Looping
        /// </summary>
        [JsonPropertyName("looping")]
        public bool Looping { get; set; } = false;

        /// <summary>
        /// Apply alpha in linear space
        /// </summary>
        [JsonPropertyName("linear_alpha")]
        public bool LinearAlpha { get; set; } = false;

        /// <summary>
        /// Restart when activated
        /// </summary>
        [JsonPropertyName("restart_on_activate")]
        public bool RestartOnActivate { get; set; } = true;

        /// <summary>
        /// ffmpeg options
        /// </summary>
        [JsonPropertyName("ffmpeg_options")]
        public string Options { get; set; }

        /// <summary>
        /// Speed percentage
        /// </summary>
        [JsonPropertyName("speed_percent")]
        public int SpeedPercent { get; set; } = 100;

        /// <summary>
        /// Static constructor to instanciate a InputFFMpegSettings object
        /// Requires an InputSettings class with InputKind of ffmpeg_source to create
        /// </summary>
        /// <param name="settings">Setings object</param>
        /// <returns></returns>
        public static InputFFMpegSettings FromInputSettings(InputSettings settings)
        {
            return new InputFFMpegSettings(settings);
        }
        // Private Constrctor
        private InputFFMpegSettings(InputSettings settings) : base((JsonObject)JsonObject.Parse(JsonSerializer.Serialize(settings))
        {
            if (settings.InputKind != SUPPORTED_INPUT_KIND)
            {
                throw new InvalidCastException();
            }
            JsonConvert.PopulateObject(settings.Settings.ToString(), this);
        }
    }
}
