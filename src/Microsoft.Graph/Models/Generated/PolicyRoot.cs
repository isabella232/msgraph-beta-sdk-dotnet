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
    /// The type Policy Root.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PolicyRoot : Entity
    {
    
		///<summary>
		/// The PolicyRoot constructor
		///</summary>
        public PolicyRoot()
        {
            this.ODataType = "microsoft.graph.policyRoot";
        }
	
        /// <summary>
        /// Gets or sets activity based timeout policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityBasedTimeoutPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IPolicyRootActivityBasedTimeoutPoliciesCollectionPage ActivityBasedTimeoutPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets claims mapping policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "claimsMappingPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IPolicyRootClaimsMappingPoliciesCollectionPage ClaimsMappingPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeRealmDiscoveryPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IPolicyRootHomeRealmDiscoveryPoliciesCollectionPage HomeRealmDiscoveryPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IPolicyRootTokenIssuancePoliciesCollectionPage TokenIssuancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenLifetimePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IPolicyRootTokenLifetimePoliciesCollectionPage TokenLifetimePolicies { get; set; }
    
    }
}

