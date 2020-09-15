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
    /// The interface IPlannerPlanRequestBuilder.
    /// </summary>
    public partial interface IPlannerPlanRequestBuilder : IPlannerDeltaRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPlannerPlanRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPlannerPlanRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Buckets.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanBucketsCollectionRequestBuilder"/>.</returns>
        IPlannerPlanBucketsCollectionRequestBuilder Buckets { get; }

        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanDetailsRequestBuilder"/>.</returns>
        IPlannerPlanDetailsRequestBuilder Details { get; }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanTasksCollectionRequestBuilder"/>.</returns>
        IPlannerPlanTasksCollectionRequestBuilder Tasks { get; }
    
    }
}