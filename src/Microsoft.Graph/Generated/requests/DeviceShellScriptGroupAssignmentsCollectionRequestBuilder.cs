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
    /// The type DeviceShellScriptGroupAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceShellScriptGroupAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IDeviceShellScriptGroupAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceShellScriptGroupAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceShellScriptGroupAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceShellScriptGroupAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceShellScriptGroupAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceShellScriptGroupAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptGroupAssignmentRequestBuilder"/> for the specified DeviceShellScriptDeviceManagementScriptGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the DeviceShellScriptDeviceManagementScriptGroupAssignment.</param>
        /// <returns>The <see cref="IDeviceManagementScriptGroupAssignmentRequestBuilder"/>.</returns>
        public IDeviceManagementScriptGroupAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementScriptGroupAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
