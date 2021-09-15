// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Inputs
{

    public sealed class DeliveryStreamExtendedS3DestinationConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("bucketARN", required: true)]
        public Input<string> BucketARN { get; set; } = null!;

        [Input("bufferingHints")]
        public Input<Inputs.DeliveryStreamBufferingHintsArgs>? BufferingHints { get; set; }

        [Input("cloudWatchLoggingOptions")]
        public Input<Inputs.DeliveryStreamCloudWatchLoggingOptionsArgs>? CloudWatchLoggingOptions { get; set; }

        [Input("compressionFormat")]
        public Input<string>? CompressionFormat { get; set; }

        [Input("dataFormatConversionConfiguration")]
        public Input<Inputs.DeliveryStreamDataFormatConversionConfigurationArgs>? DataFormatConversionConfiguration { get; set; }

        [Input("dynamicPartitioningConfiguration")]
        public Input<Inputs.DeliveryStreamDynamicPartitioningConfigurationArgs>? DynamicPartitioningConfiguration { get; set; }

        [Input("encryptionConfiguration")]
        public Input<Inputs.DeliveryStreamEncryptionConfigurationArgs>? EncryptionConfiguration { get; set; }

        [Input("errorOutputPrefix")]
        public Input<string>? ErrorOutputPrefix { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("processingConfiguration")]
        public Input<Inputs.DeliveryStreamProcessingConfigurationArgs>? ProcessingConfiguration { get; set; }

        [Input("roleARN", required: true)]
        public Input<string> RoleARN { get; set; } = null!;

        [Input("s3BackupConfiguration")]
        public Input<Inputs.DeliveryStreamS3DestinationConfigurationArgs>? S3BackupConfiguration { get; set; }

        [Input("s3BackupMode")]
        public Input<string>? S3BackupMode { get; set; }

        public DeliveryStreamExtendedS3DestinationConfigurationArgs()
        {
        }
    }
}
