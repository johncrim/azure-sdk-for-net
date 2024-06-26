// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The status profile of the addons and other kubernetes components. </summary>
    public partial class ProvisionedClusterAddonStatusProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        internal ProvisionedClusterAddonStatusProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        /// <param name="name"> Name of the addon or component. </param>
        /// <param name="phase"> Observed phase of the addon or component on the provisioned cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </param>
        /// <param name="ready"> Indicates whether the addon or component is ready. </param>
        /// <param name="errorMessage"> Observed error message from the addon or component. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClusterAddonStatusProfile(string name, ProvisionedClusterAddonPhase? phase, bool? ready, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Phase = phase;
            Ready = ready;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the addon or component. </summary>
        public string Name { get; }
        /// <summary> Observed phase of the addon or component on the provisioned cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </summary>
        public ProvisionedClusterAddonPhase? Phase { get; }
        /// <summary> Indicates whether the addon or component is ready. </summary>
        public bool? Ready { get; }
        /// <summary> Observed error message from the addon or component. </summary>
        public string ErrorMessage { get; }
    }
}
