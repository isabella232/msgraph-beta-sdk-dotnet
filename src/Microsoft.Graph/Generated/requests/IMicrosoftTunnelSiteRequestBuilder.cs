// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IMicrosoftTunnelSiteRequestBuilder.
    /// </summary>
    public partial interface IMicrosoftTunnelSiteRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IMicrosoftTunnelSiteRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IMicrosoftTunnelSiteRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for MicrosoftTunnelConfiguration.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelConfigurationRequestBuilder"/>.</returns>
        IMicrosoftTunnelConfigurationRequestBuilder MicrosoftTunnelConfiguration { get; }

        /// <summary>
        /// Gets the request builder for MicrosoftTunnelServers.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder"/>.</returns>
        IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder MicrosoftTunnelServers { get; }
    
    }
}
