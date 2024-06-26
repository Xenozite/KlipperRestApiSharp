﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperStatusProbe : ObservableObject
    {
        #region Properties
        [ObservableProperty, JsonIgnore]
        [property: JsonProperty("last_z_result")]
        double? lastZResult;

        [ObservableProperty, JsonIgnore]
        [property: JsonProperty("last_query")]
        bool lastQuery;
        #endregion

        #region Overrides
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
        #endregion
    }
}
