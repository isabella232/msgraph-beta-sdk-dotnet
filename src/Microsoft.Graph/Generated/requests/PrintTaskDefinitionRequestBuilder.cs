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
    /// The type PrintTaskDefinitionRequestBuilder.
    /// </summary>
    public partial class PrintTaskDefinitionRequestBuilder : EntityRequestBuilder, IPrintTaskDefinitionRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrintTaskDefinitionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrintTaskDefinitionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPrintTaskDefinitionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPrintTaskDefinitionRequest Request(IEnumerable<Option> options)
        {
            return new PrintTaskDefinitionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPrintTaskDefinitionTasksCollectionRequestBuilder"/>.</returns>
        public IPrintTaskDefinitionTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new PrintTaskDefinitionTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }
    
    }
}
