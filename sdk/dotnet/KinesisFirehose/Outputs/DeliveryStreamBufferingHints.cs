// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Outputs
{

    [OutputType]
    public sealed class DeliveryStreamBufferingHints
    {
        public readonly int? IntervalInSeconds;
        public readonly int? SizeInMBs;

        [OutputConstructor]
        private DeliveryStreamBufferingHints(
            int? intervalInSeconds,

            int? sizeInMBs)
        {
            IntervalInSeconds = intervalInSeconds;
            SizeInMBs = sizeInMBs;
        }
    }
}
