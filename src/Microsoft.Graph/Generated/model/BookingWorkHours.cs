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
    /// The type BookingWorkHours.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class BookingWorkHours
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingWorkHours"/> class.
        /// </summary>
        public BookingWorkHours()
        {
            this.ODataType = "microsoft.graph.bookingWorkHours";
        }

        /// <summary>
        /// Gets or sets day.
        /// The day of the week represented by this instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "day", Required = Newtonsoft.Json.Required.Default)]
        public DayOfWeek? Day { get; set; }
    
        /// <summary>
        /// Gets or sets timeSlots.
        /// A list of start/end times during a day.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeSlots", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<BookingWorkTimeSlot> TimeSlots { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}