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
    /// The type Group Policy Category.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyCategory : Entity
    {
    
		///<summary>
		/// The GroupPolicyCategory constructor
		///</summary>
        public GroupPolicyCategory()
        {
            this.ODataType = "microsoft.graph.groupPolicyCategory";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The string id of the category's display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is root.
        /// Defines if the category is a root category
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRoot", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsRoot { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// The children categories
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "children", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPolicyCategoryChildrenCollectionWithReferencesPage Children { get; set; }
    
        /// <summary>
        /// Gets or sets definition file.
        /// The id of the definition file the category came from
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definitionFile", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicyDefinitionFile DefinitionFile { get; set; }
    
        /// <summary>
        /// Gets or sets definitions.
        /// The immediate GroupPolicyDefinition children of the category
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definitions", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPolicyCategoryDefinitionsCollectionWithReferencesPage Definitions { get; set; }
    
        /// <summary>
        /// Gets or sets parent.
        /// The parent category
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicyCategory Parent { get; set; }
    
    }
}
