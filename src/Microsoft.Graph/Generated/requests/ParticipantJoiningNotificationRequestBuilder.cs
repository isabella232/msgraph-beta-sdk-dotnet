// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ParticipantJoiningNotificationRequestBuilder.
    /// </summary>
    public partial class ParticipantJoiningNotificationRequestBuilder : EntityRequestBuilder, IParticipantJoiningNotificationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ParticipantJoiningNotificationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ParticipantJoiningNotificationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IParticipantJoiningNotificationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IParticipantJoiningNotificationRequest Request(IEnumerable<Option> options)
        {
            return new ParticipantJoiningNotificationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Call.
        /// </summary>
        /// <returns>The <see cref="ICallRequestBuilder"/>.</returns>
        public ICallRequestBuilder Call
        {
            get
            {
                return new CallRequestBuilder(this.AppendSegmentToRequestUrl("call"), this.Client);
            }
        }
    
    }
}
