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
    /// The type PrintJobRedirectRequestBuilder.
    /// </summary>
    public partial class PrintJobRedirectRequestBuilder : BaseActionMethodRequestBuilder<IPrintJobRedirectRequest>, IPrintJobRedirectRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="PrintJobRedirectRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="destinationPrinterId">A destinationPrinterId parameter for the OData method call.</param>
        /// <param name="configuration">A configuration parameter for the OData method call.</param>
        public PrintJobRedirectRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string destinationPrinterId,
            PrintJobConfiguration configuration)
            : base(requestUrl, client)
        {
            this.SetParameter("destinationPrinterId", destinationPrinterId, true);
            this.SetParameter("configuration", configuration, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IPrintJobRedirectRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new PrintJobRedirectRequest(functionUrl, this.Client, options);

            if (this.HasParameter("destinationPrinterId"))
            {
                request.RequestBody.DestinationPrinterId = this.GetParameter<string>("destinationPrinterId");
            }

            if (this.HasParameter("configuration"))
            {
                request.RequestBody.Configuration = this.GetParameter<PrintJobConfiguration>("configuration");
            }

            return request;
        }
    }
}
