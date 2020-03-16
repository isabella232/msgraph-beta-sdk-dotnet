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
    /// The enum IosSoftwareUpdateScheduleType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum IosSoftwareUpdateScheduleType
    {
    
        /// <summary>
        /// Update Outside Of Active Hours
        /// </summary>
        UpdateOutsideOfActiveHours = 0,
	
        /// <summary>
        /// Always Update
        /// </summary>
        AlwaysUpdate = 1,
	
        /// <summary>
        /// Update During Time Windows
        /// </summary>
        UpdateDuringTimeWindows = 2,
	
        /// <summary>
        /// Update Outside Of Time Windows
        /// </summary>
        UpdateOutsideOfTimeWindows = 3,
	
    }
}
