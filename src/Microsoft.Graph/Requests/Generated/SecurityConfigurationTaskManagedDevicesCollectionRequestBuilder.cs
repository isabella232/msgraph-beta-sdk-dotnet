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
    /// The type SecurityConfigurationTaskManagedDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class SecurityConfigurationTaskManagedDevicesCollectionRequestBuilder : BaseRequestBuilder, ISecurityConfigurationTaskManagedDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SecurityConfigurationTaskManagedDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityConfigurationTaskManagedDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISecurityConfigurationTaskManagedDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISecurityConfigurationTaskManagedDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SecurityConfigurationTaskManagedDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IVulnerableManagedDeviceRequestBuilder"/> for the specified SecurityConfigurationTaskVulnerableManagedDevice.
        /// </summary>
        /// <param name="id">The ID for the SecurityConfigurationTaskVulnerableManagedDevice.</param>
        /// <returns>The <see cref="IVulnerableManagedDeviceRequestBuilder"/>.</returns>
        public IVulnerableManagedDeviceRequestBuilder this[string id]
        {
            get
            {
                return new VulnerableManagedDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
