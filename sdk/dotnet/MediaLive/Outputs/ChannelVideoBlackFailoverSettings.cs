// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html
    /// </summary>
    [OutputType]
    public sealed class ChannelVideoBlackFailoverSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-blackdetectthreshold
        /// </summary>
        public readonly double? BlackDetectThreshold;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-videoblackthresholdmsec
        /// </summary>
        public readonly int? VideoBlackThresholdMsec;

        [OutputConstructor]
        private ChannelVideoBlackFailoverSettings(
            double? blackDetectThreshold,

            int? videoBlackThresholdMsec)
        {
            BlackDetectThreshold = blackDetectThreshold;
            VideoBlackThresholdMsec = videoBlackThresholdMsec;
        }
    }
}