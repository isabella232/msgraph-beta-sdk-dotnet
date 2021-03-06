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
    /// The type DeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder : BaseRequestBuilder, IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceCustomAttributeShellScriptUserRunStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptUserStateRequestBuilder"/> for the specified DeviceCustomAttributeShellScriptDeviceManagementScriptUserState.
        /// </summary>
        /// <param name="id">The ID for the DeviceCustomAttributeShellScriptDeviceManagementScriptUserState.</param>
        /// <returns>The <see cref="IDeviceManagementScriptUserStateRequestBuilder"/>.</returns>
        public IDeviceManagementScriptUserStateRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementScriptUserStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
