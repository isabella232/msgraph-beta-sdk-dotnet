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
    /// The interface IWindowsAutopilotDeploymentProfilePolicySetItemRequest.
    /// </summary>
    public partial interface IWindowsAutopilotDeploymentProfilePolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> CreateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate);        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> CreateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <returns>The WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> GetAsync();

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <returns>The updated WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> UpdateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate);

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> UpdateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> selectExpression);

    }
}
