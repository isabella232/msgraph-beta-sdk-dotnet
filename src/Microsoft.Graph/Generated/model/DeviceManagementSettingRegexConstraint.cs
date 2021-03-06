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
    /// The type DeviceManagementSettingRegexConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementSettingRegexConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingRegexConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingRegexConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingRegexConstraint";
        }

        /// <summary>
        /// Gets or sets regex.
        /// The RegEx pattern to match against
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "regex", Required = Newtonsoft.Json.Required.Default)]
        public string Regex { get; set; }
    
    }
}
