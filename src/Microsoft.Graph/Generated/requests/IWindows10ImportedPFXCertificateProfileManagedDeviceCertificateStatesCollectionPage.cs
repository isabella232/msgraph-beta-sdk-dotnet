// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionPage>))]
    public interface IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionPage : ICollectionPage<ManagedDeviceCertificateState>
    {
        /// <summary>
        /// Gets the next page <see cref="IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequest"/> instance.
        /// </summary>
        IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}