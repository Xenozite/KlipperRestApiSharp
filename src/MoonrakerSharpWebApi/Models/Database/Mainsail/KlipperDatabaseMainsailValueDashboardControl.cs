﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperDatabaseMainsailValueDashboardControl : ObservableObject
    {
        #region Properties
        [ObservableProperty]

        [JsonProperty("useCross")]
        public partial bool UseCross { get; set; }
        #endregion

        #region Overrides
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
        #endregion
    }
}
