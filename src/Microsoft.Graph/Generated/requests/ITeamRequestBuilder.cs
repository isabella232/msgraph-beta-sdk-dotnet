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
    /// The interface ITeamRequestBuilder.
    /// </summary>
    public partial interface ITeamRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ITeamRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ITeamRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Schedule.
        /// </summary>
        /// <returns>The <see cref="IScheduleRequestBuilder"/>.</returns>
        IScheduleRequestBuilder Schedule { get; }

        /// <summary>
        /// Gets the request builder for Channels.
        /// </summary>
        /// <returns>The <see cref="ITeamChannelsCollectionRequestBuilder"/>.</returns>
        ITeamChannelsCollectionRequestBuilder Channels { get; }

        /// <summary>
        /// Gets the request builder for Group.
        /// </summary>
        /// <returns>The <see cref="IGroupWithReferenceRequestBuilder"/>.</returns>
        IGroupWithReferenceRequestBuilder Group { get; }

        /// <summary>
        /// Gets the request builder for InstalledApps.
        /// </summary>
        /// <returns>The <see cref="ITeamInstalledAppsCollectionRequestBuilder"/>.</returns>
        ITeamInstalledAppsCollectionRequestBuilder InstalledApps { get; }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="ITeamMembersCollectionRequestBuilder"/>.</returns>
        ITeamMembersCollectionRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ITeamOperationsCollectionRequestBuilder"/>.</returns>
        ITeamOperationsCollectionRequestBuilder Operations { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="ITeamOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        ITeamOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }

        /// <summary>
        /// Gets the request builder for PrimaryChannel.
        /// </summary>
        /// <returns>The <see cref="IChannelRequestBuilder"/>.</returns>
        IChannelRequestBuilder PrimaryChannel { get; }

        /// <summary>
        /// Gets the request builder for Template.
        /// </summary>
        /// <returns>The <see cref="ITeamsTemplateWithReferenceRequestBuilder"/>.</returns>
        ITeamsTemplateWithReferenceRequestBuilder Template { get; }
    
        /// <summary>
        /// Gets the request builder for TeamArchive.
        /// </summary>
        /// <returns>The <see cref="ITeamArchiveRequestBuilder"/>.</returns>
        ITeamArchiveRequestBuilder Archive(
            bool? shouldSetSpoSiteReadOnlyForMembers = null);

        /// <summary>
        /// Gets the request builder for TeamClone.
        /// </summary>
        /// <returns>The <see cref="ITeamCloneRequestBuilder"/>.</returns>
        ITeamCloneRequestBuilder Clone(
            TeamVisibilityType visibility,
            ClonableTeamParts partsToClone,
            string displayName = null,
            string description = null,
            string mailNickname = null,
            string classification = null);

        /// <summary>
        /// Gets the request builder for TeamCompleteMigration.
        /// </summary>
        /// <returns>The <see cref="ITeamCompleteMigrationRequestBuilder"/>.</returns>
        ITeamCompleteMigrationRequestBuilder CompleteMigration();

        /// <summary>
        /// Gets the request builder for TeamSendActivityNotification.
        /// </summary>
        /// <returns>The <see cref="ITeamSendActivityNotificationRequestBuilder"/>.</returns>
        ITeamSendActivityNotificationRequestBuilder SendActivityNotification(
            TeamworkActivityTopic topic = null,
            string activityType = null,
            Int64? chainId = null,
            ItemBody previewText = null,
            IEnumerable<KeyValuePair> templateParameters = null,
            TeamworkNotificationRecipient recipient = null);

        /// <summary>
        /// Gets the request builder for TeamUnarchive.
        /// </summary>
        /// <returns>The <see cref="ITeamUnarchiveRequestBuilder"/>.</returns>
        ITeamUnarchiveRequestBuilder Unarchive();
    
    }
}