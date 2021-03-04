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
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertytimestamp.html#cfn-iot-topicrule-assetpropertytimestamp-offsetinnanos
        /// </summary>
        public readonly string? OffsetInNanos;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertytimestamp.html#cfn-iot-topicrule-assetpropertytimestamp-timeinseconds
        /// </summary>
        public readonly string TimeInSeconds;

        [OutputConstructor]
        private TopicRuleAssetPropertyTimestamp(
            string? OffsetInNanos,

            string TimeInSeconds)
        {
            this.OffsetInNanos = OffsetInNanos;
            this.TimeInSeconds = TimeInSeconds;
        }
    }
}
