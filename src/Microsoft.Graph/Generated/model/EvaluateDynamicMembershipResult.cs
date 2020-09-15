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
    /// The type EvaluateDynamicMembershipResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EvaluateDynamicMembershipResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateDynamicMembershipResult"/> class.
        /// </summary>
        public EvaluateDynamicMembershipResult()
        {
            this.ODataType = "microsoft.graph.evaluateDynamicMembershipResult";
        }

        /// <summary>
        /// Gets or sets membershipRule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRule", Required = Newtonsoft.Json.Required.Default)]
        public string MembershipRule { get; set; }
    
        /// <summary>
        /// Gets or sets membershipRuleEvaluationDetails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRuleEvaluationDetails", Required = Newtonsoft.Json.Required.Default)]
        public ExpressionEvaluationDetails MembershipRuleEvaluationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets membershipRuleEvaluationResult.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRuleEvaluationResult", Required = Newtonsoft.Json.Required.Default)]
        public bool? MembershipRuleEvaluationResult { get; set; }
    
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