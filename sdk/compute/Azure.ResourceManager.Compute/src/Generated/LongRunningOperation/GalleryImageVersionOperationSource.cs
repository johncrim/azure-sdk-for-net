// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class GalleryImageVersionOperationSource : IOperationSource<GalleryImageVersionResource>
    {
        private readonly ArmClient _client;

        internal GalleryImageVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryImageVersionResource IOperationSource<GalleryImageVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GalleryImageVersionData.DeserializeGalleryImageVersionData(document.RootElement);
            return new GalleryImageVersionResource(_client, data);
        }

        async ValueTask<GalleryImageVersionResource> IOperationSource<GalleryImageVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GalleryImageVersionData.DeserializeGalleryImageVersionData(document.RootElement);
            return new GalleryImageVersionResource(_client, data);
        }
    }
}
