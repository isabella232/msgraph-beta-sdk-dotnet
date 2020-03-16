// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Sensitivity Policy Settings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SensitivityPolicySettings : Entity
    {
    
		///<summary>
		/// The SensitivityPolicySettings constructor
		///</summary>
        public SensitivityPolicySettings()
        {
            this.ODataType = "microsoft.graph.sensitivityPolicySettings";
        }
	
        /// <summary>
        /// Gets or sets is mandatory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMandatory", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMandatory { get; set; }
    
        /// <summary>
        /// Gets or sets help web url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "helpWebUrl", Required = Newtonsoft.Json.Required.Default)]
        public string HelpWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets downgrade sensitivity requires justification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "downgradeSensitivityRequiresJustification", Required = Newtonsoft.Json.Required.Default)]
        public bool? DowngradeSensitivityRequiresJustification { get; set; }
    
        /// <summary>
        /// Gets or sets applicable to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicableTo", Required = Newtonsoft.Json.Required.Default)]
        public SensitivityLabelTarget? ApplicableTo { get; set; }
    
    }
}

