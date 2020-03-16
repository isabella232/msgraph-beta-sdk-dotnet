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
    /// The type ServicePrincipalRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalRequestBuilder : DirectoryObjectRequestBuilder, IServicePrincipalRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IServicePrincipalRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IServicePrincipalRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AppRoleAssignedTo.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignedToCollectionRequestBuilder"/>.</returns>
        public IServicePrincipalAppRoleAssignedToCollectionRequestBuilder AppRoleAssignedTo
        {
            get
            {
                return new ServicePrincipalAppRoleAssignedToCollectionRequestBuilder(this.AppendSegmentToRequestUrl("appRoleAssignedTo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AppRoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        public IServicePrincipalAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments
        {
            get
            {
                return new ServicePrincipalAppRoleAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("appRoleAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClaimsMappingPolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesRequestBuilder ClaimsMappingPolicies
        {
            get
            {
                return new ServicePrincipalClaimsMappingPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("claimsMappingPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder HomeRealmDiscoveryPolicies
        {
            get
            {
                return new ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("homeRealmDiscoveryPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Endpoints.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalEndpointsCollectionRequestBuilder"/>.</returns>
        public IServicePrincipalEndpointsCollectionRequestBuilder Endpoints
        {
            get
            {
                return new ServicePrincipalEndpointsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("endpoints"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Oauth2PermissionGrants.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder Oauth2PermissionGrants
        {
            get
            {
                return new ServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("oauth2PermissionGrants"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalMemberOfCollectionWithReferencesRequestBuilder MemberOf
        {
            get
            {
                return new ServicePrincipalMemberOfCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("memberOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf
        {
            get
            {
                return new ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("transitiveMemberOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CreatedObjects.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalCreatedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalCreatedObjectsCollectionWithReferencesRequestBuilder CreatedObjects
        {
            get
            {
                return new ServicePrincipalCreatedObjectsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("createdObjects"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LicenseDetails.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalLicenseDetailsCollectionRequestBuilder"/>.</returns>
        public IServicePrincipalLicenseDetailsCollectionRequestBuilder LicenseDetails
        {
            get
            {
                return new ServicePrincipalLicenseDetailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("licenseDetails"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalOwnersCollectionWithReferencesRequestBuilder Owners
        {
            get
            {
                return new ServicePrincipalOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("owners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for OwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalOwnedObjectsCollectionWithReferencesRequestBuilder OwnedObjects
        {
            get
            {
                return new ServicePrincipalOwnedObjectsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("ownedObjects"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesRequestBuilder TokenIssuancePolicies
        {
            get
            {
                return new ServicePrincipalTokenIssuancePoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tokenIssuancePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder TokenLifetimePolicies
        {
            get
            {
                return new ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tokenLifetimePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Synchronization.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationRequestBuilder"/>.</returns>
        public ISynchronizationRequestBuilder Synchronization
        {
            get
            {
                return new SynchronizationRequestBuilder(this.AppendSegmentToRequestUrl("synchronization"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ServicePrincipalCreatePasswordSingleSignOnCredentials.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalCreatePasswordSingleSignOnCredentialsRequestBuilder"/>.</returns>
        public IServicePrincipalCreatePasswordSingleSignOnCredentialsRequestBuilder CreatePasswordSingleSignOnCredentials(
            string id,
            IEnumerable<Credential> credentials)
        {
            return new ServicePrincipalCreatePasswordSingleSignOnCredentialsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createPasswordSingleSignOnCredentials"),
                this.Client,
                id,
                credentials);
        }

        /// <summary>
        /// Gets the request builder for ServicePrincipalGetPasswordSingleSignOnCredentials.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalGetPasswordSingleSignOnCredentialsRequestBuilder"/>.</returns>
        public IServicePrincipalGetPasswordSingleSignOnCredentialsRequestBuilder GetPasswordSingleSignOnCredentials(
            string id)
        {
            return new ServicePrincipalGetPasswordSingleSignOnCredentialsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getPasswordSingleSignOnCredentials"),
                this.Client,
                id);
        }

        /// <summary>
        /// Gets the request builder for ServicePrincipalDeletePasswordSingleSignOnCredentials.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalDeletePasswordSingleSignOnCredentialsRequestBuilder"/>.</returns>
        public IServicePrincipalDeletePasswordSingleSignOnCredentialsRequestBuilder DeletePasswordSingleSignOnCredentials(
            string id)
        {
            return new ServicePrincipalDeletePasswordSingleSignOnCredentialsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.deletePasswordSingleSignOnCredentials"),
                this.Client,
                id);
        }

        /// <summary>
        /// Gets the request builder for ServicePrincipalUpdatePasswordSingleSignOnCredentials.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder"/>.</returns>
        public IServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder UpdatePasswordSingleSignOnCredentials(
            string id,
            IEnumerable<Credential> credentials)
        {
            return new ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updatePasswordSingleSignOnCredentials"),
                this.Client,
                id,
                credentials);
        }
    
    }
}
