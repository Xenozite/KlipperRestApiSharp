﻿using Newtonsoft.Json;

namespace AndreasReitberger.Models
{
    public class KlipperProfile
    {
        #region Properties
        public string Name { get; set; }
        #endregion 

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}