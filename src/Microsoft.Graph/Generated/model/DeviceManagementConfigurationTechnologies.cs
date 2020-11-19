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
    /// The enum DeviceManagementConfigurationTechnologies.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum DeviceManagementConfigurationTechnologies
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Mdm
        /// </summary>
        Mdm = 1,
	
        /// <summary>
        /// Windows10XManagement
        /// </summary>
        Windows10XManagement = 2,
	
        /// <summary>
        /// Config Manager
        /// </summary>
        ConfigManager = 4,
	
    }
}