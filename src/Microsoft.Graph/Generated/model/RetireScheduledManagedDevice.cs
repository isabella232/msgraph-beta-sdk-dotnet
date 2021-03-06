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
    /// The type RetireScheduledManagedDevice.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RetireScheduledManagedDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetireScheduledManagedDevice"/> class.
        /// </summary>
        public RetireScheduledManagedDevice()
        {
            this.ODataType = "microsoft.graph.retireScheduledManagedDevice";
        }

        /// <summary>
        /// Gets or sets complianceState.
        /// Managed Device ComplianceStatus
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceState", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceStatus? ComplianceState { get; set; }
    
        /// <summary>
        /// Gets or sets deviceCompliancePolicyId.
        /// Device Compliance PolicyId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceCompliancePolicyId { get; set; }
    
        /// <summary>
        /// Gets or sets deviceCompliancePolicyName.
        /// Device Compliance Policy Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceCompliancePolicyName { get; set; }
    
        /// <summary>
        /// Gets or sets deviceType.
        /// Managed Device Device Type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceType? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Key of the entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets managedDeviceId.
        /// Managed DeviceId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets managedDeviceName.
        /// Managed Device Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managementAgent.
        /// Managed Device ManagementAgentType
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementAgent", Required = Newtonsoft.Json.Required.Default)]
        public ManagementAgentType? ManagementAgent { get; set; }
    
        /// <summary>
        /// Gets or sets ownerType.
        /// Managed Device ManagedDeviceOwnerType
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerType", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceOwnerType? OwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets retireAfterDateTime.
        /// Managed Device Retire After DateTime
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "retireAfterDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RetireAfterDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets roleScopeTagIds.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
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
