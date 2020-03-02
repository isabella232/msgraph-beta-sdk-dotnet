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
    /// The enum RestrictionTrigger.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RestrictionTrigger
    {
    
        /// <summary>
        /// Copy Paste
        /// </summary>
        CopyPaste = 0,
	
        /// <summary>
        /// Copy To Network Share
        /// </summary>
        CopyToNetworkShare = 1,
	
        /// <summary>
        /// Copy To Removable Media
        /// </summary>
        CopyToRemovableMedia = 2,
	
        /// <summary>
        /// Screen Capture
        /// </summary>
        ScreenCapture = 3,
	
        /// <summary>
        /// Print
        /// </summary>
        Print = 4,
	
        /// <summary>
        /// Cloud Egress
        /// </summary>
        CloudEgress = 5,
	
        /// <summary>
        /// Unallowed Apps
        /// </summary>
        UnallowedApps = 6,
	
    }
}