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
    /// The type Fido2Authentication Method.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fido2AuthenticationMethod : AuthenticationMethod
    {
    
		///<summary>
		/// The Fido2AuthenticationMethod constructor
		///</summary>
        public Fido2AuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.fido2AuthenticationMethod";
        }
	
        /// <summary>
        /// Gets or sets aa guid.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "aaGuid", Required = Newtonsoft.Json.Required.Default)]
        public string AaGuid { get; set; }
    
        /// <summary>
        /// Gets or sets attestation certificates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attestationCertificates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AttestationCertificates { get; set; }
    
        /// <summary>
        /// Gets or sets attestation level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attestationLevel", Required = Newtonsoft.Json.Required.Default)]
        public AttestationLevel? AttestationLevel { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
    }
}

