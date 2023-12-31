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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    internal partial class SearchRequestInternalDTO
    {
        /// <summary>
        /// Channel filter conditions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> FilterConditions { get; set; } = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Number of messages to return
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// Message filter conditions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_filter_conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> MessageFilterConditions { get; set; }

        /// <summary>
        /// Pagination parameter. Cannot be used with non-zero offset.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Next { get; set; }

        /// <summary>
        /// Pagination offset. Cannot be used with sort or next.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// Search phrase
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// Sort parameters. Cannot be used with non-zero offset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<SortParamInternalDTO> Sort { get; set; }

        private System.Collections.Generic.Dictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.Dictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

