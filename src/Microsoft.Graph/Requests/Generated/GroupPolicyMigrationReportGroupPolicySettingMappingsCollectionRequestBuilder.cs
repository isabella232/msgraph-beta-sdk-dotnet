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
    /// The type GroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder.
    /// </summary>
    public partial class GroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder : BaseRequestBuilder, IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGroupPolicySettingMappingRequestBuilder"/> for the specified GroupPolicyMigrationReportGroupPolicySettingMapping.
        /// </summary>
        /// <param name="id">The ID for the GroupPolicyMigrationReportGroupPolicySettingMapping.</param>
        /// <returns>The <see cref="IGroupPolicySettingMappingRequestBuilder"/>.</returns>
        public IGroupPolicySettingMappingRequestBuilder this[string id]
        {
            get
            {
                return new GroupPolicySettingMappingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}