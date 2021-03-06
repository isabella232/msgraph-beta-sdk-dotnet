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
    /// The enum ChatType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ChatType
    {
    
        /// <summary>
        /// One On One
        /// </summary>
        OneOnOne = 0,
	
        /// <summary>
        /// Group
        /// </summary>
        Group = 1,
	
        /// <summary>
        /// Meeting
        /// </summary>
        Meeting = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
