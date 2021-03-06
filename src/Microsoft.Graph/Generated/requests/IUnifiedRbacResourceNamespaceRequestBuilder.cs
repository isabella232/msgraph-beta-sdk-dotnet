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
    /// The interface IUnifiedRbacResourceNamespaceRequestBuilder.
    /// </summary>
    public partial interface IUnifiedRbacResourceNamespaceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUnifiedRbacResourceNamespaceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUnifiedRbacResourceNamespaceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ResourceActions.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRbacResourceNamespaceResourceActionsCollectionRequestBuilder"/>.</returns>
        IUnifiedRbacResourceNamespaceResourceActionsCollectionRequestBuilder ResourceActions { get; }
    
        /// <summary>
        /// Gets the request builder for UnifiedRbacResourceNamespaceImportResourceActions.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRbacResourceNamespaceImportResourceActionsRequestBuilder"/>.</returns>
        IUnifiedRbacResourceNamespaceImportResourceActionsRequestBuilder ImportResourceActions(
            string format,
            string value,
            bool overwriteResourceNamespace);
    
    }
}
