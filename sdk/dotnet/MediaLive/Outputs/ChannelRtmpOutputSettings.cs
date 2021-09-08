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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html
    /// </summary>
    [OutputType]
    public sealed class ChannelRtmpOutputSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-certificatemode
        /// </summary>
        public readonly string? CertificateMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-connectionretryinterval
        /// </summary>
        public readonly int? ConnectionRetryInterval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-destination
        /// </summary>
        public readonly Outputs.ChannelOutputLocationRef? Destination;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-numretries
        /// </summary>
        public readonly int? NumRetries;

        [OutputConstructor]
        private ChannelRtmpOutputSettings(
            string? certificateMode,

            int? connectionRetryInterval,

            Outputs.ChannelOutputLocationRef? destination,

            int? numRetries)
        {
            CertificateMode = certificateMode;
            ConnectionRetryInterval = connectionRetryInterval;
            Destination = destination;
            NumRetries = numRetries;
        }
    }
}