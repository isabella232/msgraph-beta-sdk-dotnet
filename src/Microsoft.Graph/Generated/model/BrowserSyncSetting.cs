// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum BrowserSyncSetting.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum BrowserSyncSetting
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Blocked With User Override
        /// </summary>
        BlockedWithUserOverride = 1,
	
        /// <summary>
        /// Blocked
        /// </summary>
        Blocked = 2,
	
    }
}
