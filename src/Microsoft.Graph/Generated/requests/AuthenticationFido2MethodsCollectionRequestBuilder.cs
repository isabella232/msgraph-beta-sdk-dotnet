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
    /// The type AuthenticationFido2MethodsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationFido2MethodsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationFido2MethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationFido2MethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationFido2MethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationFido2MethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationFido2MethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationFido2MethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IFido2AuthenticationMethodRequestBuilder"/> for the specified AuthenticationFido2AuthenticationMethod.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationFido2AuthenticationMethod.</param>
        /// <returns>The <see cref="IFido2AuthenticationMethodRequestBuilder"/>.</returns>
        public IFido2AuthenticationMethodRequestBuilder this[string id]
        {
            get
            {
                return new Fido2AuthenticationMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
