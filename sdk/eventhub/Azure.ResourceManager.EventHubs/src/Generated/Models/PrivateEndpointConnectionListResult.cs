// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Result of the list of all private endpoint connections operation. </summary>
    internal partial class PrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        internal PrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> A collection of private endpoint connection resources. </param>
        /// <param name="nextLink"> A link for the next page of private endpoint connection resources. </param>
        internal PrivateEndpointConnectionListResult(IReadOnlyList<PrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of private endpoint connection resources. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> Value { get; }
        /// <summary> A link for the next page of private endpoint connection resources. </summary>
        public string NextLink { get; }
    }
}
