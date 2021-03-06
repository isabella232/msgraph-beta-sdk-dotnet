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
    /// The interface IOfficeClientConfigurationRequestBuilder.
    /// </summary>
    public partial interface IOfficeClientConfigurationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOfficeClientConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOfficeClientConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        IOfficeClientConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }
    
        /// <summary>
        /// Gets the request builder for PolicyPayload.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationPolicyPayloadRequestBuilder"/>.</returns>
        IOfficeClientConfigurationPolicyPayloadRequestBuilder PolicyPayload { get; }

        /// <summary>
        /// Gets the request builder for UserPreferencePayload.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationUserPreferencePayloadRequestBuilder"/>.</returns>
        IOfficeClientConfigurationUserPreferencePayloadRequestBuilder UserPreferencePayload { get; }
    
        /// <summary>
        /// Gets the request builder for OfficeClientConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationAssignRequestBuilder"/>.</returns>
        IOfficeClientConfigurationAssignRequestBuilder Assign(
            IEnumerable<OfficeClientConfigurationAssignment> officeConfigurationAssignments = null);
    
    }
}
