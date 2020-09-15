// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device App Management.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceAppManagement : Entity
    {
    
		///<summary>
		/// The DeviceAppManagement constructor
		///</summary>
        public DeviceAppManagement()
        {
            this.ODataType = "microsoft.graph.deviceAppManagement";
        }
	
        /// <summary>
        /// Gets or sets is enabled for microsoft store for business.
        /// Whether the account is enabled for syncing applications from the Microsoft Store for Business.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabledForMicrosoftStoreForBusiness", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business language.
        /// The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&amp;lt;country/regioncode2&amp;gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &amp;lt;country/regioncode2&amp;gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftStoreForBusinessLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string MicrosoftStoreForBusinessLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last completed application sync time.
        /// The last time an application sync from the Microsoft Store for Business was completed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftStoreForBusinessLastCompletedApplicationSyncTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last successful sync date time.
        /// The last time the apps from the Microsoft Store for Business were synced successfully for the account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftStoreForBusinessLastSuccessfulSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business portal selection.
        /// The end user portal information is used to sync applications from the Microsoft Store for Business to Intune Company Portal. There are three options to pick from ['Company portal only', 'Company portal and private store', 'Private store only']
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftStoreForBusinessPortalSelection", Required = Newtonsoft.Json.Required.Default)]
        public MicrosoftStoreForBusinessPortalSelectionOptions? MicrosoftStoreForBusinessPortalSelection { get; set; }
    
        /// <summary>
        /// Gets or sets managed ebook categories.
        /// The mobile eBook categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedEBookCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementManagedEBookCategoriesCollectionPage ManagedEBookCategories { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise code signing certificates.
        /// The Windows Enterprise Code Signing Certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseCodeSigningCertificates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionPage EnterpriseCodeSigningCertificates { get; set; }
    
        /// <summary>
        /// Gets or sets ios lob app provisioning configurations.
        /// The IOS Lob App Provisioning Configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosLobAppProvisioningConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionPage IosLobAppProvisioningConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app categories.
        /// The mobile app categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementMobileAppCategoriesCollectionPage MobileAppCategories { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app configurations.
        /// The Managed Device Mobile Application Configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementMobileAppConfigurationsCollectionPage MobileAppConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets mobile apps.
        /// The mobile apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileApps", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementMobileAppsCollectionPage MobileApps { get; set; }
    
        /// <summary>
        /// Gets or sets symantec code signing certificate.
        /// The WinPhone Symantec Code Signing Certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "symantecCodeSigningCertificate", Required = Newtonsoft.Json.Required.Default)]
        public SymantecCodeSigningCertificate SymantecCodeSigningCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets managed ebooks.
        /// The Managed eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedEBooks", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementManagedEBooksCollectionPage ManagedEBooks { get; set; }
    
        /// <summary>
        /// Gets or sets policy sets.
        /// The PolicySet of Policies and Applications
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policySets", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementPolicySetsCollectionPage PolicySets { get; set; }
    
        /// <summary>
        /// Gets or sets side loading keys.
        /// Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sideLoadingKeys", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementSideLoadingKeysCollectionPage SideLoadingKeys { get; set; }
    
        /// <summary>
        /// Gets or sets vpp tokens.
        /// List of Vpp tokens for this organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokens", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementVppTokensCollectionPage VppTokens { get; set; }
    
        /// <summary>
        /// Gets or sets windows management app.
        /// Windows management app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsManagementApp", Required = Newtonsoft.Json.Required.Default)]
        public WindowsManagementApp WindowsManagementApp { get; set; }
    
        /// <summary>
        /// Gets or sets android managed app protections.
        /// Android managed app policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidManagedAppProtections", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionPage AndroidManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets default managed app protections.
        /// Default managed app policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultManagedAppProtections", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionPage DefaultManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets ios managed app protections.
        /// iOS managed app policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosManagedAppProtections", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementIosManagedAppProtectionsCollectionPage IosManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets managed app policies.
        /// Managed app policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedAppPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementManagedAppPoliciesCollectionPage ManagedAppPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets managed app registrations.
        /// The managed app registrations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedAppRegistrations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementManagedAppRegistrationsCollectionPage ManagedAppRegistrations { get; set; }
    
        /// <summary>
        /// Gets or sets managed app statuses.
        /// The managed app statuses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedAppStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementManagedAppStatusesCollectionPage ManagedAppStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets mdm windows information protection policies.
        /// Windows information protection for apps running on devices which are MDM enrolled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmWindowsInformationProtectionPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionPage MdmWindowsInformationProtectionPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets targeted managed app configurations.
        /// Targeted managed app configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedManagedAppConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionPage TargetedManagedAppConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection device registrations.
        /// Windows information protection device registrations that are not MDM enrolled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionDeviceRegistrations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionPage WindowsInformationProtectionDeviceRegistrations { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection policies.
        /// Windows information protection for apps running on devices which are not MDM enrolled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionPage WindowsInformationProtectionPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection wipe actions.
        /// Windows information protection wipe actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionWipeActions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionPage WindowsInformationProtectionWipeActions { get; set; }
    
        /// <summary>
        /// Gets or sets device app management tasks.
        /// Device app management tasks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceAppManagementTasks", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementDeviceAppManagementTasksCollectionPage DeviceAppManagementTasks { get; set; }
    
        /// <summary>
        /// Gets or sets wdac supplemental policies.
        /// The collection of Windows Defender Application Control Supplemental Policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wdacSupplementalPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceAppManagementWdacSupplementalPoliciesCollectionPage WdacSupplementalPolicies { get; set; }
    
    }
}
