// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class TopicRuleAssetPropertyTimestamp
    {
        public readonly string? OffsetInNanos;
        public readonly string TimeInSeconds;

        [OutputConstructor]
        private TopicRuleAssetPropertyTimestamp(
            string? offsetInNanos,

            string timeInSeconds)
        {
            OffsetInNanos = offsetInNanos;
            TimeInSeconds = timeInSeconds;
        }
    }
}
