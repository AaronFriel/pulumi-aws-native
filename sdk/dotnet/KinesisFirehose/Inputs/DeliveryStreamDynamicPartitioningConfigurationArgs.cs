// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Inputs
{

    public sealed class DeliveryStreamDynamicPartitioningConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("retryOptions")]
        public Input<Inputs.DeliveryStreamRetryOptionsArgs>? RetryOptions { get; set; }

        public DeliveryStreamDynamicPartitioningConfigurationArgs()
        {
        }
    }
}
