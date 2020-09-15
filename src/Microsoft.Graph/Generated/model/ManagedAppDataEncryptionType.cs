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
    /// The enum ManagedAppDataEncryptionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppDataEncryptionType
    {
    
        /// <summary>
        /// Use Device Settings
        /// </summary>
        UseDeviceSettings = 0,
	
        /// <summary>
        /// After Device Restart
        /// </summary>
        AfterDeviceRestart = 1,
	
        /// <summary>
        /// When Device Locked Except Open Files
        /// </summary>
        WhenDeviceLockedExceptOpenFiles = 2,
	
        /// <summary>
        /// When Device Locked
        /// </summary>
        WhenDeviceLocked = 3,
	
    }
}