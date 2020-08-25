// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ResultantAppStateDetail.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ResultantAppStateDetail
    {
    
        /// <summary>
        /// No Additional Details
        /// </summary>
        NoAdditionalDetails = 0,
	
        /// <summary>
        /// Dependency Failed To Install
        /// </summary>
        DependencyFailedToInstall = 1,
	
        /// <summary>
        /// Dependency With Requirements Not Met
        /// </summary>
        DependencyWithRequirementsNotMet = 2,
	
        /// <summary>
        /// Dependency Pending Reboot
        /// </summary>
        DependencyPendingReboot = 3,
	
        /// <summary>
        /// Dependency With Auto Install Disabled
        /// </summary>
        DependencyWithAutoInstallDisabled = 4,
	
        /// <summary>
        /// Ios App Store Update Failed To Install
        /// </summary>
        IosAppStoreUpdateFailedToInstall = 1000,
	
        /// <summary>
        /// Vpp App Has Update Available
        /// </summary>
        VppAppHasUpdateAvailable = 1001,
	
        /// <summary>
        /// User Rejected Update
        /// </summary>
        UserRejectedUpdate = 1002,
	
        /// <summary>
        /// See Install Error Code
        /// </summary>
        SeeInstallErrorCode = 2000,
	
        /// <summary>
        /// Auto Install Disabled
        /// </summary>
        AutoInstallDisabled = 3000,
	
        /// <summary>
        /// Managed App No Longer Present
        /// </summary>
        ManagedAppNoLongerPresent = 3001,
	
        /// <summary>
        /// User Rejected Install
        /// </summary>
        UserRejectedInstall = 3002,
	
        /// <summary>
        /// User Is Not Logged Into App Store
        /// </summary>
        UserIsNotLoggedIntoAppStore = 3003,
	
        /// <summary>
        /// See Uninstall Error Code
        /// </summary>
        SeeUninstallErrorCode = 4000,
	
        /// <summary>
        /// Pending Reboot
        /// </summary>
        PendingReboot = 5000,
	
        /// <summary>
        /// Installing Dependencies
        /// </summary>
        InstallingDependencies = 5001,
	
        /// <summary>
        /// Content Downloaded
        /// </summary>
        ContentDownloaded = 5002,
	
        /// <summary>
        /// Power Shell Script Requirement Not Met
        /// </summary>
        PowerShellScriptRequirementNotMet = -1013,
	
        /// <summary>
        /// Registry Requirement Not Met
        /// </summary>
        RegistryRequirementNotMet = -1012,
	
        /// <summary>
        /// File System Requirement Not Met
        /// </summary>
        FileSystemRequirementNotMet = -1011,
	
        /// <summary>
        /// Platform Not Applicable
        /// </summary>
        PlatformNotApplicable = -1006,
	
        /// <summary>
        /// Minimum Cpu Speed Not Met
        /// </summary>
        MinimumCpuSpeedNotMet = -1005,
	
        /// <summary>
        /// Minimum Logical Processor Count Not Met
        /// </summary>
        MinimumLogicalProcessorCountNotMet = -1004,
	
        /// <summary>
        /// Minimum Physical Memory Not Met
        /// </summary>
        MinimumPhysicalMemoryNotMet = -1003,
	
        /// <summary>
        /// Minimum Os Version Not Met
        /// </summary>
        MinimumOsVersionNotMet = -1002,
	
        /// <summary>
        /// Minimum Disk Space Not Met
        /// </summary>
        MinimumDiskSpaceNotMet = -1001,
	
        /// <summary>
        /// Processor Architecture Not Applicable
        /// </summary>
        ProcessorArchitectureNotApplicable = -1000,
	
    }
}
