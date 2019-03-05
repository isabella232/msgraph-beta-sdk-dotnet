// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupPolicyPresentationValueRequestBuilder.
    /// </summary>
    public partial class GroupPolicyPresentationValueRequestBuilder : EntityRequestBuilder, IGroupPolicyPresentationValueRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyPresentationValueRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyPresentationValueRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupPolicyPresentationValueRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupPolicyPresentationValueRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyPresentationValueRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DefinitionValue.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionValueWithReferenceRequestBuilder"/>.</returns>
        public IGroupPolicyDefinitionValueWithReferenceRequestBuilder DefinitionValue
        {
            get
            {
                return new GroupPolicyDefinitionValueWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("definitionValue"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Presentation.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyPresentationWithReferenceRequestBuilder"/>.</returns>
        public IGroupPolicyPresentationWithReferenceRequestBuilder Presentation
        {
            get
            {
                return new GroupPolicyPresentationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("presentation"), this.Client);
            }
        }
    
    }
}