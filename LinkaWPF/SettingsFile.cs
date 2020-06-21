﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkaWPF
{
    public class SettingsFile
    {
        [JsonProperty("keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty("isHazGazeEnabled")]
        public bool IsHazGazeEnabled { get; set; }

        [JsonProperty("isAnimatedClickEnabled")]
        public bool IsAnimatedClickEnabled { get; set; }
    }
}