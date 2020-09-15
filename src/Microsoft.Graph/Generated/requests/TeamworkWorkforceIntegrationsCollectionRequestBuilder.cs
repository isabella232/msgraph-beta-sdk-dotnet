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
    /// The type TeamworkWorkforceIntegrationsCollectionRequestBuilder.
    /// </summary>
    public partial class TeamworkWorkforceIntegrationsCollectionRequestBuilder : BaseRequestBuilder, ITeamworkWorkforceIntegrationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TeamworkWorkforceIntegrationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamworkWorkforceIntegrationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamworkWorkforceIntegrationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamworkWorkforceIntegrationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TeamworkWorkforceIntegrationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkforceIntegrationRequestBuilder"/> for the specified TeamworkWorkforceIntegration.
        /// </summary>
        /// <param name="id">The ID for the TeamworkWorkforceIntegration.</param>
        /// <returns>The <see cref="IWorkforceIntegrationRequestBuilder"/>.</returns>
        public IWorkforceIntegrationRequestBuilder this[string id]
        {
            get
            {
                return new WorkforceIntegrationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}