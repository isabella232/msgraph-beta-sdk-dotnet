// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementConfigurationPolicySettingsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicySettingsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementConfigurationPolicySettingsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationPolicySettingsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementConfigurationPolicySettingsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementConfigurationPolicySettingsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementConfigurationPolicySettingsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementConfigurationPolicySettingsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementConfigurationSettingRequestBuilder"/> for the specified DeviceManagementConfigurationPolicyDeviceManagementConfigurationSetting.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementConfigurationPolicyDeviceManagementConfigurationSetting.</param>
        /// <returns>The <see cref="IDeviceManagementConfigurationSettingRequestBuilder"/>.</returns>
        public IDeviceManagementConfigurationSettingRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementConfigurationSettingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}