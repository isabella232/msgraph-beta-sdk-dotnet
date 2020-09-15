// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type WindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionPage.
    /// </summary>
    public partial class WindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionPage : CollectionPage<ManagedDeviceCertificateState>, IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionRequest"/> instance.
        /// </summary>
        public IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new WindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}