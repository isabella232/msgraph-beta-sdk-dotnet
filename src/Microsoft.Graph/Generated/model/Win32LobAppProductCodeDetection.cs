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
    /// The type Win32LobAppProductCodeDetection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppProductCodeDetection : Win32LobAppDetection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppProductCodeDetection"/> class.
        /// </summary>
        public Win32LobAppProductCodeDetection()
        {
            this.ODataType = "microsoft.graph.win32LobAppProductCodeDetection";
        }

        /// <summary>
        /// Gets or sets productCode.
        /// The product code of Win32 Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productCode", Required = Newtonsoft.Json.Required.Default)]
        public string ProductCode { get; set; }
    
        /// <summary>
        /// Gets or sets productVersion.
        /// The product version of Win32 Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ProductVersion { get; set; }
    
        /// <summary>
        /// Gets or sets productVersionOperator.
        /// The operator to detect product version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productVersionOperator", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppDetectionOperator? ProductVersionOperator { get; set; }
    
    }
}
