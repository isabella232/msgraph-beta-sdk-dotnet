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
    /// The type GroupPolicyPresentationMultiTextBoxRequest.
    /// </summary>
    public partial class GroupPolicyPresentationMultiTextBoxRequest : BaseRequest, IGroupPolicyPresentationMultiTextBoxRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyPresentationMultiTextBoxRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyPresentationMultiTextBoxRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationMultiTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToCreate">The GroupPolicyPresentationMultiTextBox to create.</param>
        /// <returns>The created GroupPolicyPresentationMultiTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> CreateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToCreate)
        {
            return this.CreateAsync(groupPolicyPresentationMultiTextBoxToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationMultiTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToCreate">The GroupPolicyPresentationMultiTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationMultiTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> CreateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyPresentationMultiTextBox>(groupPolicyPresentationMultiTextBoxToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyPresentationMultiTextBox>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationMultiTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationMultiTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyPresentationMultiTextBox>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationMultiTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToUpdate">The GroupPolicyPresentationMultiTextBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationMultiTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> UpdateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToUpdate)
        {
            return this.UpdateAsync(groupPolicyPresentationMultiTextBoxToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationMultiTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToUpdate">The GroupPolicyPresentationMultiTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationMultiTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> UpdateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToUpdate, CancellationToken cancellationToken)
        {
			if (groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData != null)
			{
				if (groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyPresentationMultiTextBoxToUpdate.GetType().Name)
						});
				}
			}
            if (groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData != null)
            {
                if (groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupPolicyPresentationMultiTextBoxToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyPresentationMultiTextBoxToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationMultiTextBox>(groupPolicyPresentationMultiTextBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationMultiTextBoxRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationMultiTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationMultiTextBox, object>> expandExpression)
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
        public IGroupPolicyPresentationMultiTextBoxRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationMultiTextBoxRequest Select(Expression<Func<GroupPolicyPresentationMultiTextBox, object>> selectExpression)
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
        /// <param name="groupPolicyPresentationMultiTextBoxToInitialize">The <see cref="GroupPolicyPresentationMultiTextBox"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToInitialize)
        {

        }
    }
}
