// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIdentityUserFlowRequest.
    /// </summary>
    public partial interface IIdentityUserFlowRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityUserFlow using POST.
        /// </summary>
        /// <param name="identityUserFlowToCreate">The IdentityUserFlow to create.</param>
        /// <returns>The created IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> CreateAsync(IdentityUserFlow identityUserFlowToCreate);        /// <summary>
        /// Creates the specified IdentityUserFlow using POST.
        /// </summary>
        /// <param name="identityUserFlowToCreate">The IdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> CreateAsync(IdentityUserFlow identityUserFlowToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IdentityUserFlow.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IdentityUserFlow.
        /// </summary>
        /// <returns>The IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> GetAsync();

        /// <summary>
        /// Gets the specified IdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="identityUserFlowToUpdate">The IdentityUserFlow to update.</param>
        /// <returns>The updated IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> UpdateAsync(IdentityUserFlow identityUserFlowToUpdate);

        /// <summary>
        /// Updates the specified IdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="identityUserFlowToUpdate">The IdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityUserFlow.</returns>
        System.Threading.Tasks.Task<IdentityUserFlow> UpdateAsync(IdentityUserFlow identityUserFlowToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowRequest Expand(Expression<Func<IdentityUserFlow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowRequest Select(Expression<Func<IdentityUserFlow, object>> selectExpression);

    }
}