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
    public sealed class DeliveryStreamSplunkRetryOptions
    {
        public readonly int? DurationInSeconds;

        [OutputConstructor]
        private DeliveryStreamSplunkRetryOptions(int? durationInSeconds)
        {
            DurationInSeconds = durationInSeconds;
        }
    }
}
