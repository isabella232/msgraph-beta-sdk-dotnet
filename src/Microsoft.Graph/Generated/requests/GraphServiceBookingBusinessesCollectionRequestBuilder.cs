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
    /// The type GraphServiceBookingBusinessesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceBookingBusinessesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceBookingBusinessesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceBookingBusinessesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceBookingBusinessesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceBookingBusinessesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceBookingBusinessesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceBookingBusinessesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBookingBusinessRequestBuilder"/> for the specified GraphServiceBookingBusiness.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceBookingBusiness.</param>
        /// <returns>The <see cref="IBookingBusinessRequestBuilder"/>.</returns>
        public IBookingBusinessRequestBuilder this[string id]
        {
            get
            {
                return new BookingBusinessRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
