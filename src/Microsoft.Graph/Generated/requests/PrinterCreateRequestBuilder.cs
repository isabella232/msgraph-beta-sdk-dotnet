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
    /// The type PrinterCreateRequestBuilder.
    /// </summary>
    public partial class PrinterCreateRequestBuilder : BaseActionMethodRequestBuilder<IPrinterCreateRequest>, IPrinterCreateRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="PrinterCreateRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="displayName">A displayName parameter for the OData method call.</param>
        /// <param name="manufacturer">A manufacturer parameter for the OData method call.</param>
        /// <param name="model">A model parameter for the OData method call.</param>
        /// <param name="certificateSigningRequest">A certificateSigningRequest parameter for the OData method call.</param>
        /// <param name="physicalDeviceId">A physicalDeviceId parameter for the OData method call.</param>
        /// <param name="hasPhysicalDevice">A hasPhysicalDevice parameter for the OData method call.</param>
        /// <param name="connectorId">A connectorId parameter for the OData method call.</param>
        public PrinterCreateRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string displayName,
            string manufacturer,
            string model,
            PrintCertificateSigningRequestObject certificateSigningRequest,
            string physicalDeviceId,
            bool? hasPhysicalDevice,
            string connectorId)
            : base(requestUrl, client)
        {
            this.SetParameter("displayName", displayName, false);
            this.SetParameter("manufacturer", manufacturer, false);
            this.SetParameter("model", model, false);
            this.SetParameter("certificateSigningRequest", certificateSigningRequest, false);
            this.SetParameter("physicalDeviceId", physicalDeviceId, true);
            this.SetParameter("hasPhysicalDevice", hasPhysicalDevice, true);
            this.SetParameter("connectorId", connectorId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IPrinterCreateRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new PrinterCreateRequest(functionUrl, this.Client, options);

            if (this.HasParameter("displayName"))
            {
                request.RequestBody.DisplayName = this.GetParameter<string>("displayName");
            }

            if (this.HasParameter("manufacturer"))
            {
                request.RequestBody.Manufacturer = this.GetParameter<string>("manufacturer");
            }

            if (this.HasParameter("model"))
            {
                request.RequestBody.Model = this.GetParameter<string>("model");
            }

            if (this.HasParameter("certificateSigningRequest"))
            {
                request.RequestBody.CertificateSigningRequest = this.GetParameter<PrintCertificateSigningRequestObject>("certificateSigningRequest");
            }

            if (this.HasParameter("physicalDeviceId"))
            {
                request.RequestBody.PhysicalDeviceId = this.GetParameter<string>("physicalDeviceId");
            }

            if (this.HasParameter("hasPhysicalDevice"))
            {
                request.RequestBody.HasPhysicalDevice = this.GetParameter<bool?>("hasPhysicalDevice");
            }

            if (this.HasParameter("connectorId"))
            {
                request.RequestBody.ConnectorId = this.GetParameter<string>("connectorId");
            }

            return request;
        }
    }
}