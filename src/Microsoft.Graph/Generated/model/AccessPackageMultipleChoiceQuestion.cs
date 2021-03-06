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
    /// The type AccessPackageMultipleChoiceQuestion.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessPackageMultipleChoiceQuestion : AccessPackageQuestion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPackageMultipleChoiceQuestion"/> class.
        /// </summary>
        public AccessPackageMultipleChoiceQuestion()
        {
            this.ODataType = "microsoft.graph.accessPackageMultipleChoiceQuestion";
        }

        /// <summary>
        /// Gets or sets allowsMultipleSelection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowsMultipleSelection", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowsMultipleSelection { get; set; }
    
        /// <summary>
        /// Gets or sets choices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "choices", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AccessPackageAnswerChoice> Choices { get; set; }
    
    }
}
