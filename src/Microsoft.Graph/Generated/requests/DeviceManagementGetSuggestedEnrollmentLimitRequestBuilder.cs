// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementGetSuggestedEnrollmentLimitRequestBuilder.
    /// </summary>
    public partial class DeviceManagementGetSuggestedEnrollmentLimitRequestBuilder : BaseFunctionMethodRequestBuilder<IDeviceManagementGetSuggestedEnrollmentLimitRequest>, IDeviceManagementGetSuggestedEnrollmentLimitRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementGetSuggestedEnrollmentLimitRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="enrollmentType">A enrollmentType parameter for the OData method call.</param>
        public DeviceManagementGetSuggestedEnrollmentLimitRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string enrollmentType)
            : base(requestUrl, client)
        {
            this.SetParameter("enrollmentType", enrollmentType, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementGetSuggestedEnrollmentLimitRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementGetSuggestedEnrollmentLimitRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
