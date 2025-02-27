﻿using AndreasReitberger.API.Moonraker.Models;
using AndreasReitberger.API.Print3dServer.Core;
using AndreasReitberger.API.Print3dServer.Core.Interfaces;
using AndreasReitberger.API.Print3dServer.Core.JSON.Newtonsoft;
using AndreasReitberger.API.REST;
using AndreasReitberger.API.REST.Interfaces;
using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker
{
    public partial class MoonrakerClient
    {

#if DEBUG
        #region Debug

        [ObservableProperty]
        [JsonIgnore, System.Text.Json.Serialization.JsonIgnore, XmlIgnore]
        public new partial JsonSerializerSettings NewtonsoftJsonSerializerSettings { get; set; } = DefaultNewtonsoftJsonSerializerSettings;

        public new static JsonSerializerSettings DefaultNewtonsoftJsonSerializerSettings = new()
        {
            // Detect if the json respone has more or less properties than the target class
            //MissingMemberHandling = MissingMemberHandling.Error,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Include,
            TypeNameHandling = TypeNameHandling.Auto,
            Converters =
            {
                // Map the converters
                new AbstractConverter<AuthenticationHeader, IAuthenticationHeader>(),
                new AbstractConverter<KlipperGcodeMetaResult, IGcodeMeta>(),
                new AbstractConverter<KlipperGcodeThumbnail, IGcodeImage>(),
                new AbstractConverter<KlipperJobQueueItem, IPrint3dJob>(),
                new AbstractConverter<KlipperStatusJob, IPrint3dJobStatus>(),
                new AbstractConverter<KlipperDatabaseWebcamConfig, IWebCamConfig>(),
                new AbstractConverter<KlipperStatusExtruder, IToolhead>(),
                new AbstractConverter<KlipperStatusFan, IPrint3dFan>(),
                new AbstractConverter<KlipperStatusFilamentSensor, ISensorComponent>(),
            }
        };
        #endregion
#else
        #region Release
        public new static JsonSerializerSettings DefaultNewtonsoftJsonSerializerSettings = new()
        {
            // Ignore if the json respone has more or less properties than the target class
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            TypeNameHandling = TypeNameHandling.Auto,
            Converters =
            {
                // Map the converters
                new AbstractConverter<AuthenticationHeader, IAuthenticationHeader>(),
                new AbstractConverter<KlipperGcodeMetaResult, IGcodeMeta>(),
                new AbstractConverter<KlipperGcodeThumbnail, IGcodeImage>(),
                new AbstractConverter<KlipperJobQueueItem, IPrint3dJob>(),
                new AbstractConverter<KlipperStatusJob, IPrint3dJobStatus>(),
                new AbstractConverter<KlipperDatabaseWebcamConfig, IWebCamConfig>(),
                new AbstractConverter<KlipperStatusExtruder, IToolhead>(),
                new AbstractConverter<KlipperStatusFan, IPrint3dFan>(),
                new AbstractConverter<KlipperStatusFilamentSensor, ISensorComponent>(),
            }
        };
        #endregion
#endif
    }
}
