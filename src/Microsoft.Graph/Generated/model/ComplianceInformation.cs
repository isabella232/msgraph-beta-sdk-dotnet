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
    /// The type ComplianceInformation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ComplianceInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceInformation"/> class.
        /// </summary>
        public ComplianceInformation()
        {
            this.ODataType = "microsoft.graph.complianceInformation";
        }

        /// <summary>
        /// Gets or sets certificationControls.
        /// Collection of the certification controls associated with certification
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationControls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CertificationControl> CertificationControls { get; set; }
    
        /// <summary>
        /// Gets or sets certificationName.
        /// Compliance certification name (for example, ISO 27018:2014, GDPR, FedRAMP, NIST 800-171)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationName { get; set; }
    
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
