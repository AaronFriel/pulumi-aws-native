// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Inputs
{

    public sealed class DeliveryStreamSplunkDestinationConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("cloudWatchLoggingOptions")]
        public Input<Inputs.DeliveryStreamCloudWatchLoggingOptionsArgs>? CloudWatchLoggingOptions { get; set; }

        [Input("hECAcknowledgmentTimeoutInSeconds")]
        public Input<int>? HECAcknowledgmentTimeoutInSeconds { get; set; }

        [Input("hECEndpoint", required: true)]
        public Input<string> HECEndpoint { get; set; } = null!;

        [Input("hECEndpointType", required: true)]
        public Input<Pulumi.AwsNative.KinesisFirehose.DeliveryStreamSplunkDestinationConfigurationHECEndpointType> HECEndpointType { get; set; } = null!;

        [Input("hECToken", required: true)]
        public Input<string> HECToken { get; set; } = null!;

        [Input("processingConfiguration")]
        public Input<Inputs.DeliveryStreamProcessingConfigurationArgs>? ProcessingConfiguration { get; set; }

        [Input("retryOptions")]
        public Input<Inputs.DeliveryStreamSplunkRetryOptionsArgs>? RetryOptions { get; set; }

        [Input("s3BackupMode")]
        public Input<string>? S3BackupMode { get; set; }

        [Input("s3Configuration", required: true)]
        public Input<Inputs.DeliveryStreamS3DestinationConfigurationArgs> S3Configuration { get; set; } = null!;

        public DeliveryStreamSplunkDestinationConfigurationArgs()
        {
        }
    }
}
