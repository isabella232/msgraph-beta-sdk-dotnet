// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupPolicyDefinitionWithReferenceRequestBuilder.
    /// </summary>
    public partial class GroupPolicyDefinitionWithReferenceRequestBuilder : BaseRequestBuilder, IGroupPolicyDefinitionWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyDefinitionWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyDefinitionWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyDefinitionWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the groupPolicyDefinition.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionReferenceRequestBuilder"/>.</returns>
        public IGroupPolicyDefinitionReferenceRequestBuilder Reference
        {
            get
            {
                return new GroupPolicyDefinitionReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}