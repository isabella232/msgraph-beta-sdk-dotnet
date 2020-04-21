// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type GroupPolicyUploadedDefinitionFileUploadNewVersionRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyUploadedDefinitionFileUploadNewVersionRequestBody
    {
    
        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Content { get; set; }
    
        /// <summary>
        /// Gets or sets GroupPolicyUploadedLanguageFiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyUploadedLanguageFiles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles { get; set; }
    
    }
}