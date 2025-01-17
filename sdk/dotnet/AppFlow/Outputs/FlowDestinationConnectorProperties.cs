// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    /// <summary>
    /// Destination connector details
    /// </summary>
    [OutputType]
    public sealed class FlowDestinationConnectorProperties
    {
        public readonly Outputs.FlowEventBridgeDestinationProperties? EventBridge;
        public readonly Outputs.FlowLookoutMetricsDestinationProperties? LookoutMetrics;
        public readonly Outputs.FlowRedshiftDestinationProperties? Redshift;
        public readonly Outputs.FlowS3DestinationProperties? S3;
        public readonly Outputs.FlowSalesforceDestinationProperties? Salesforce;
        public readonly Outputs.FlowSnowflakeDestinationProperties? Snowflake;
        public readonly Outputs.FlowUpsolverDestinationProperties? Upsolver;
        public readonly Outputs.FlowZendeskDestinationProperties? Zendesk;

        [OutputConstructor]
        private FlowDestinationConnectorProperties(
            Outputs.FlowEventBridgeDestinationProperties? eventBridge,

            Outputs.FlowLookoutMetricsDestinationProperties? lookoutMetrics,

            Outputs.FlowRedshiftDestinationProperties? redshift,

            Outputs.FlowS3DestinationProperties? s3,

            Outputs.FlowSalesforceDestinationProperties? salesforce,

            Outputs.FlowSnowflakeDestinationProperties? snowflake,

            Outputs.FlowUpsolverDestinationProperties? upsolver,

            Outputs.FlowZendeskDestinationProperties? zendesk)
        {
            EventBridge = eventBridge;
            LookoutMetrics = lookoutMetrics;
            Redshift = redshift;
            S3 = s3;
            Salesforce = salesforce;
            Snowflake = snowflake;
            Upsolver = upsolver;
            Zendesk = zendesk;
        }
    }
}
