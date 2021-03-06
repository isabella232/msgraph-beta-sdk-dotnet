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
    /// The type Ios Update Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosUpdateConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The IosUpdateConfiguration constructor
		///</summary>
        public IosUpdateConfiguration()
        {
            this.ODataType = "microsoft.graph.iosUpdateConfiguration";
        }
	
        /// <summary>
        /// Gets or sets active hours end.
        /// Active Hours End (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursEnd", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursEnd { get; set; }
    
        /// <summary>
        /// Gets or sets active hours start.
        /// Active Hours Start (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursStart", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursStart { get; set; }
    
        /// <summary>
        /// Gets or sets custom update time windows.
        /// If update schedule type is set to use time window scheduling, custom time windows when updates will be scheduled. This collection can contain a maximum of 20 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customUpdateTimeWindows", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CustomUpdateTimeWindow> CustomUpdateTimeWindows { get; set; }
    
        /// <summary>
        /// Gets or sets desired os version.
        /// If left unspecified, devices will update to the latest version of the OS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "desiredOsVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DesiredOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets enforced software update delay in days.
        /// Days before software updates are visible to iOS devices ranging from 0 to 90 inclusive
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforcedSoftwareUpdateDelayInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EnforcedSoftwareUpdateDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Is setting enabled in UI
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled install days.
        /// Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduledInstallDays", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DayOfWeek> ScheduledInstallDays { get; set; }
    
        /// <summary>
        /// Gets or sets update schedule type.
        /// Update schedule type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateScheduleType", Required = Newtonsoft.Json.Required.Default)]
        public IosSoftwareUpdateScheduleType? UpdateScheduleType { get; set; }
    
        /// <summary>
        /// Gets or sets utc time offset in minutes.
        /// UTC Time Offset indicated in minutes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "utcTimeOffsetInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UtcTimeOffsetInMinutes { get; set; }
    
    }
}

