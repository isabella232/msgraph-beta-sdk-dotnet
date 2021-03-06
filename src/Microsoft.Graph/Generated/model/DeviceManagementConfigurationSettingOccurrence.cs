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
    /// The type DeviceManagementConfigurationSettingOccurrence.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceManagementConfigurationSettingOccurrence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationSettingOccurrence"/> class.
        /// </summary>
        public DeviceManagementConfigurationSettingOccurrence()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSettingOccurrence";
        }

        /// <summary>
        /// Gets or sets maxDeviceOccurrence.
        /// Maximum times setting can be set on device. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxDeviceOccurrence", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaxDeviceOccurrence { get; set; }
    
        /// <summary>
        /// Gets or sets minDeviceOccurrence.
        /// Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minDeviceOccurrence", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinDeviceOccurrence { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
