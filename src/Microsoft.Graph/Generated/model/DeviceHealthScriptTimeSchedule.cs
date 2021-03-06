// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceHealthScriptTimeSchedule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public abstract partial class DeviceHealthScriptTimeSchedule : DeviceHealthScriptRunSchedule
    {

        /// <summary>
        /// Gets or sets time.
        /// At what time the script is scheduled to run. This collection can contain a maximum of 20 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "time", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay Time { get; set; }
    
        /// <summary>
        /// Gets or sets useUtc.
        /// Indicate if the time is Utc or client local time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useUtc", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseUtc { get; set; }
    
    }
}
