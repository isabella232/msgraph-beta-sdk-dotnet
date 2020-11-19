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
    /// The type Cloud Pc Provisioning Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudPcProvisioningPolicy : Entity
    {
    
		///<summary>
		/// The CloudPcProvisioningPolicy constructor
		///</summary>
        public CloudPcProvisioningPolicy()
        {
            this.ODataType = "microsoft.graph.cloudPcProvisioningPolicy";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets image display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imageDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ImageDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets image id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imageId", Required = Newtonsoft.Json.Required.Default)]
        public string ImageId { get; set; }
    
        /// <summary>
        /// Gets or sets image type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imageType", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcProvisioningPolicyImageType? ImageType { get; set; }
    
        /// <summary>
        /// Gets or sets on premises connection id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesConnectionId", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesConnectionId { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public ICloudPcProvisioningPolicyAssignmentsCollectionPage Assignments { get; set; }
    
    }
}
