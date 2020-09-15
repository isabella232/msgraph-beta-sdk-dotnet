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
    /// The type OnPremisesPublishingProfileConnectorsCollectionRequestBuilder.
    /// </summary>
    public partial class OnPremisesPublishingProfileConnectorsCollectionRequestBuilder : BaseRequestBuilder, IOnPremisesPublishingProfileConnectorsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OnPremisesPublishingProfileConnectorsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnPremisesPublishingProfileConnectorsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOnPremisesPublishingProfileConnectorsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOnPremisesPublishingProfileConnectorsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OnPremisesPublishingProfileConnectorsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConnectorRequestBuilder"/> for the specified OnPremisesPublishingProfileConnector.
        /// </summary>
        /// <param name="id">The ID for the OnPremisesPublishingProfileConnector.</param>
        /// <returns>The <see cref="IConnectorRequestBuilder"/>.</returns>
        public IConnectorRequestBuilder this[string id]
        {
            get
            {
                return new ConnectorRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}