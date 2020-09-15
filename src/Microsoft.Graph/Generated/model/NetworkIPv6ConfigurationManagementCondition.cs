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
    /// The type Network IPv6Configuration Management Condition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class NetworkIPv6ConfigurationManagementCondition : NetworkManagementCondition
    {
    
		///<summary>
		/// The NetworkIPv6ConfigurationManagementCondition constructor
		///</summary>
        public NetworkIPv6ConfigurationManagementCondition()
        {
            this.ODataType = "microsoft.graph.networkIPv6ConfigurationManagementCondition";
        }
	
        /// <summary>
        /// Gets or sets dns suffix list.
        /// Valid DNS suffixes for the current network. e.g. seattle.contoso.com
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsSuffixList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DnsSuffixList { get; set; }
    
        /// <summary>
        /// Gets or sets ip v6dnsserver list.
        /// An IPv6 DNS servers configured for the adapter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV6DNSServerList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> IpV6DNSServerList { get; set; }
    
        /// <summary>
        /// Gets or sets ip v6gateway.
        /// The IPv6 gateway address to. e.g 2001:db8::1
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV6Gateway", Required = Newtonsoft.Json.Required.Default)]
        public string IpV6Gateway { get; set; }
    
        /// <summary>
        /// Gets or sets ip v6prefix.
        /// The IPv6 subnet to be connected to. e.g. 2001:db8::/32
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV6Prefix", Required = Newtonsoft.Json.Required.Default)]
        public string IpV6Prefix { get; set; }
    
    }
}
