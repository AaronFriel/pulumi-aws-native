// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppIntegrations.Outputs
{

    [OutputType]
    public sealed class EventIntegrationAssociation
    {
        /// <summary>
        /// The metadata associated with the client.
        /// </summary>
        public readonly ImmutableArray<Outputs.EventIntegrationMetadata> ClientAssociationMetadata;
        /// <summary>
        /// The identifier for the client that is associated with the event integration.
        /// </summary>
        public readonly string? ClientId;
        /// <summary>
        /// The name of the Eventbridge rule.
        /// </summary>
        public readonly string? EventBridgeRuleName;
        /// <summary>
        /// The Amazon Resource Name (ARN) for the event integration association.
        /// </summary>
        public readonly string? EventIntegrationAssociationArn;
        /// <summary>
        /// The identifier for the event integration association.
        /// </summary>
        public readonly string? EventIntegrationAssociationId;

        [OutputConstructor]
        private EventIntegrationAssociation(
            ImmutableArray<Outputs.EventIntegrationMetadata> clientAssociationMetadata,

            string? clientId,

            string? eventBridgeRuleName,

            string? eventIntegrationAssociationArn,

            string? eventIntegrationAssociationId)
        {
            ClientAssociationMetadata = clientAssociationMetadata;
            ClientId = clientId;
            EventBridgeRuleName = eventBridgeRuleName;
            EventIntegrationAssociationArn = eventIntegrationAssociationArn;
            EventIntegrationAssociationId = eventIntegrationAssociationId;
        }
    }
}
