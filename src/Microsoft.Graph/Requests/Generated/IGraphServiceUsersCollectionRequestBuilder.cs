// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceUsersCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceUsersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceUsersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceUsersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserRequestBuilder"/> for the specified User.
        /// </summary>
        /// <param name="id">The ID for the User.</param>
        /// <returns>The <see cref="IUserRequestBuilder"/>.</returns>
        IUserRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UserDelta.
        /// </summary>
        /// <returns>The <see cref="IUserDeltaRequestBuilder"/>.</returns>
        IUserDeltaRequestBuilder Delta();

        /// <summary>
        /// Gets the request builder for UserGetManagedAppBlockedUsers.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppBlockedUsersRequestBuilder"/>.</returns>
        IUserGetManagedAppBlockedUsersRequestBuilder GetManagedAppBlockedUsers();
    }
}
