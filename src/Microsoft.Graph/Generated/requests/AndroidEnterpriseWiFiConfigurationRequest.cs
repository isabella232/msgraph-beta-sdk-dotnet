// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AndroidEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial class AndroidEnterpriseWiFiConfigurationRequest : BaseRequest, IAndroidEnterpriseWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new AndroidEnterpriseWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidEnterpriseWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToCreate">The AndroidEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> CreateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToCreate)
        {
            return this.CreateAsync(androidEnterpriseWiFiConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToCreate">The AndroidEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> CreateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidEnterpriseWiFiConfiguration>(androidEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToUpdate">The AndroidEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> UpdateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToUpdate)
        {
            return this.UpdateAsync(androidEnterpriseWiFiConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToUpdate">The AndroidEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> UpdateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (androidEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
			{
				if (androidEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidEnterpriseWiFiConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (androidEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
            {
                if (androidEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidEnterpriseWiFiConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidEnterpriseWiFiConfiguration>(androidEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidEnterpriseWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidEnterpriseWiFiConfiguration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidEnterpriseWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidEnterpriseWiFiConfiguration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToInitialize">The <see cref="AndroidEnterpriseWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToInitialize)
        {

        }
    }
}
