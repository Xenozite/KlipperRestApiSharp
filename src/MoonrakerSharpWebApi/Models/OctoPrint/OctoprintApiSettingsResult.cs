﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class OctoprintApiSettingsResult : ObservableObject
    {
        #region Properties
        [ObservableProperty, JsonIgnore]
        [property: JsonProperty("plugins")]
        Dictionary<string, OctoprintApiPlugin> plugins = [];

        [ObservableProperty, JsonIgnore]
        [property: JsonProperty("feature")]
        OctoprintApiFeature? feature;

        [ObservableProperty, JsonIgnore]
        [property: JsonProperty("webcam")]
        OctoprintApiWebcam? webcam;
        #endregion

        #region Overrides
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
        #endregion
    }
}
