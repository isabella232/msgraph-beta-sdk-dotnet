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
    /// The type ProtectSite.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProtectSite : LabelActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectSite"/> class.
        /// </summary>
        public ProtectSite()
        {
            this.ODataType = "microsoft.graph.protectSite";
        }

        /// <summary>
        /// Gets or sets accessType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessType", Required = Newtonsoft.Json.Required.Default)]
        public SiteAccessType? AccessType { get; set; }
    
        /// <summary>
        /// Gets or sets conditionalAccessProtectionLevelId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessProtectionLevelId", Required = Newtonsoft.Json.Required.Default)]
        public string ConditionalAccessProtectionLevelId { get; set; }
    
    }
}
