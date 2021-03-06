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
    /// The type Mac OSCertificate Profile Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSCertificateProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal MacOSCertificateProfileBase constructor
		///</summary>
        protected internal MacOSCertificateProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// Scale for the Certificate Validity Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodScale", Required = Newtonsoft.Json.Required.Default)]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// Value for the Certificate Validity Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets renewal threshold percentage.
        /// Certificate renewal threshold percentage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewalThresholdPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RenewalThresholdPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name type.
        /// Certificate Subject Alternative Name Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameType", Required = Newtonsoft.Json.Required.Default)]
        public SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format.
        /// Certificate Subject Name Format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormat", Required = Newtonsoft.Json.Required.Default)]
        public AppleSubjectNameFormat? SubjectNameFormat { get; set; }
    
    }
}

