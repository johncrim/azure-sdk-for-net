// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Creates or updates an AuthorizationRule for the specified Event Hub. Creation/update of the AuthorizationRule will take a few seconds to take effect. </summary>
    public partial class EventHubCreateOrUpdateAuthorizationRuleOperation : Operation<EventHubAuthorizationRule>
    {
        private readonly OperationOrResponseInternals<EventHubAuthorizationRule> _operation;

        /// <summary> Initializes a new instance of EventHubCreateOrUpdateAuthorizationRuleOperation for mocking. </summary>
        protected EventHubCreateOrUpdateAuthorizationRuleOperation()
        {
        }

        internal EventHubCreateOrUpdateAuthorizationRuleOperation(ArmResource operationsBase, Response<AuthorizationRuleData> response)
        {
            _operation = new OperationOrResponseInternals<EventHubAuthorizationRule>(Response.FromValue(new EventHubAuthorizationRule(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override EventHubAuthorizationRule Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EventHubAuthorizationRule>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EventHubAuthorizationRule>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
