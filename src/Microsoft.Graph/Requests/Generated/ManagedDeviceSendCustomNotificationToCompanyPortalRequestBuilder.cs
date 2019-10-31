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
    /// The type ManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder : BaseActionMethodRequestBuilder<IManagedDeviceSendCustomNotificationToCompanyPortalRequest>, IManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="notificationTitle">A notificationTitle parameter for the OData method call.</param>
        /// <param name="notificationBody">A notificationBody parameter for the OData method call.</param>
        public ManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string notificationTitle,
            string notificationBody)
            : base(requestUrl, client)
        {
            this.SetParameter("notificationTitle", notificationTitle, false);
            this.SetParameter("notificationBody", notificationBody, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedDeviceSendCustomNotificationToCompanyPortalRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedDeviceSendCustomNotificationToCompanyPortalRequest(functionUrl, this.Client, options);

            if (this.HasParameter("notificationTitle"))
            {
                request.RequestBody.NotificationTitle = this.GetParameter<string>("notificationTitle");
            }

            if (this.HasParameter("notificationBody"))
            {
                request.RequestBody.NotificationBody = this.GetParameter<string>("notificationBody");
            }

            return request;
        }
    }
}