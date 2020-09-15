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
    /// The type DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMdmWindowsInformationProtectionPolicyRequestBuilder"/> for the specified DeviceAppManagementMdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementMdmWindowsInformationProtectionPolicy.</param>
        /// <returns>The <see cref="IMdmWindowsInformationProtectionPolicyRequestBuilder"/>.</returns>
        public IMdmWindowsInformationProtectionPolicyRequestBuilder this[string id]
        {
            get
            {
                return new MdmWindowsInformationProtectionPolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MdmWindowsInformationProtectionPolicyHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IMdmWindowsInformationProtectionPolicyHasPayloadLinksRequestBuilder"/>.</returns>
        public IMdmWindowsInformationProtectionPolicyHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null)
        {
            return new MdmWindowsInformationProtectionPolicyHasPayloadLinksRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.hasPayloadLinks"),
                this.Client,
                payloadIds);
        }
    }
}