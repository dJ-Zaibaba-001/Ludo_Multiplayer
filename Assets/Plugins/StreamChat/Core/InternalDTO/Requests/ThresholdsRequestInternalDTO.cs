﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using StreamChat.Core.InternalDTO.Responses;
using StreamChat.Core.InternalDTO.Events;
using StreamChat.Core.InternalDTO.Models;

namespace StreamChat.Core.InternalDTO.Requests
{
    using System = global::System;

    /// <summary>
    /// Sets thresholds for AI moderation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    internal partial class ThresholdsRequestInternalDTO
    {
        /// <summary>
        /// Thresholds for explicit messages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("explicit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LabelThresholdsRequestInternalDTO Explicit { get; set; }

        /// <summary>
        /// Thresholds for spam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LabelThresholdsRequestInternalDTO Spam { get; set; }

        /// <summary>
        /// Thresholds for toxic messages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toxic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LabelThresholdsRequestInternalDTO Toxic { get; set; }

        private System.Collections.Generic.Dictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.Dictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

