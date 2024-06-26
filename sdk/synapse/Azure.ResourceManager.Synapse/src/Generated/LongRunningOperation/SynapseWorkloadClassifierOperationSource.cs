// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseWorkloadClassifierOperationSource : IOperationSource<SynapseWorkloadClassifierResource>
    {
        private readonly ArmClient _client;

        internal SynapseWorkloadClassifierOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseWorkloadClassifierResource IOperationSource<SynapseWorkloadClassifierResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseWorkloadClassifierData.DeserializeSynapseWorkloadClassifierData(document.RootElement);
            return new SynapseWorkloadClassifierResource(_client, data);
        }

        async ValueTask<SynapseWorkloadClassifierResource> IOperationSource<SynapseWorkloadClassifierResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseWorkloadClassifierData.DeserializeSynapseWorkloadClassifierData(document.RootElement);
            return new SynapseWorkloadClassifierResource(_client, data);
        }
    }
}
