// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Inputs
{

    public sealed class DeliveryStreamKinesisStreamSourceConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("kinesisStreamARN", required: true)]
        public Input<string> KinesisStreamARN { get; set; } = null!;

        [Input("roleARN", required: true)]
        public Input<string> RoleARN { get; set; } = null!;

        public DeliveryStreamKinesisStreamSourceConfigurationArgs()
        {
        }
    }
}
