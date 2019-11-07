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
    /// The enum PropertyType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PropertyType
    {
    
        /// <summary>
        /// String
        /// </summary>
        @String = 0,
	
        /// <summary>
        /// Int64
        /// </summary>
        Int64 = 1,
	
        /// <summary>
        /// Double
        /// </summary>
        Double = 2,
	
        /// <summary>
        /// Date Time
        /// </summary>
        DateTime = 3,
	
        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 4,
	
        /// <summary>
        /// Collection(String)
        /// </summary>
        StringCollection = 5,

        /// <summary>
        /// Collection(Int64)
        /// </summary>
        Int64Collection = 6,
	
        /// <summary>
        /// Collection(Double)
        /// </summary>
        DoubleCollection = 7,
	
        /// <summary>
        /// Collection(Date Time)
        /// </summary>
        DateTimeCollection = 8,
	
    }
}