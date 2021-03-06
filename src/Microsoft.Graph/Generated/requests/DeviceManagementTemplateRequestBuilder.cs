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
    /// The type DeviceManagementTemplateRequestBuilder.
    /// </summary>
    public partial class DeviceManagementTemplateRequestBuilder : EntityRequestBuilder, IDeviceManagementTemplateRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementTemplateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementTemplateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceManagementTemplateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceManagementTemplateRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementTemplateRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateCategoriesCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementTemplateCategoriesCollectionRequestBuilder Categories
        {
            get
            {
                return new DeviceManagementTemplateCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("categories"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MigratableTo.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateMigratableToCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementTemplateMigratableToCollectionRequestBuilder MigratableTo
        {
            get
            {
                return new DeviceManagementTemplateMigratableToCollectionRequestBuilder(this.AppendSegmentToRequestUrl("migratableTo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateSettingsCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementTemplateSettingsCollectionRequestBuilder Settings
        {
            get
            {
                return new DeviceManagementTemplateSettingsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("settings"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementTemplateCreateInstance.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateCreateInstanceRequestBuilder"/>.</returns>
        public IDeviceManagementTemplateCreateInstanceRequestBuilder CreateInstance(
            string displayName = null,
            string description = null,
            IEnumerable<DeviceManagementSettingInstance> settingsDelta = null,
            IEnumerable<string> roleScopeTagIds = null)
        {
            return new DeviceManagementTemplateCreateInstanceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createInstance"),
                this.Client,
                displayName,
                description,
                settingsDelta,
                roleScopeTagIds);
        }

        /// <summary>
        /// Gets the request builder for DeviceManagementTemplateCompare.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateCompareRequestBuilder"/>.</returns>
        public IDeviceManagementTemplateCompareRequestBuilder Compare(
            string templateId = null)
        {
            return new DeviceManagementTemplateCompareRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.compare"),
                this.Client,
                templateId);
        }
    
    }
}
