// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelNielsenConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-distributorid
        /// </summary>
        public readonly string? DistributorId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-nielsenpcmtoid3tagging
        /// </summary>
        public readonly string? NielsenPcmToId3Tagging;

        [OutputConstructor]
        private ChannelNielsenConfiguration(
            string? DistributorId,

            string? NielsenPcmToId3Tagging)
        {
            this.DistributorId = DistributorId;
            this.NielsenPcmToId3Tagging = NielsenPcmToId3Tagging;
        }
    }
}
