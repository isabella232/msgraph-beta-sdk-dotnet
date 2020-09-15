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
    /// The type Symantec Code Signing Certificate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SymantecCodeSigningCertificate : Entity
    {
    
		///<summary>
		/// The SymantecCodeSigningCertificate constructor
		///</summary>
        public SymantecCodeSigningCertificate()
        {
            this.ODataType = "microsoft.graph.symantecCodeSigningCertificate";
        }
	
        /// <summary>
        /// Gets or sets content.
        /// The Windows Symantec Code-Signing Certificate in the raw data format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Content { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The Cert Expiration Date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets issuer.
        /// The Issuer value for the cert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuer", Required = Newtonsoft.Json.Required.Default)]
        public string Issuer { get; set; }
    
        /// <summary>
        /// Gets or sets issuer name.
        /// The Issuer Name for the cert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuerName", Required = Newtonsoft.Json.Required.Default)]
        public string IssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets password.
        /// The Password required for .pfx file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "password", Required = Newtonsoft.Json.Required.Default)]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The Cert Status Provisioned or not Provisioned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public CertificateStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The Subject value for the cert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets subject name.
        /// The Subject Name for the cert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectName", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectName { get; set; }
    
        /// <summary>
        /// Gets or sets upload date time.
        /// The Type of the CodeSigning Cert as Symantec Cert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uploadDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? UploadDateTime { get; set; }
    
    }
}
