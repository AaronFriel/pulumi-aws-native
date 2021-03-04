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
    public sealed class ChannelStandardHlsSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-audiorenditionsets
        /// </summary>
        public readonly string? AudioRenditionSets;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-m3u8settings
        /// </summary>
        public readonly Outputs.ChannelM3u8Settings? M3u8Settings;

        [OutputConstructor]
        private ChannelStandardHlsSettings(
            string? AudioRenditionSets,

            Outputs.ChannelM3u8Settings? M3u8Settings)
        {
            this.AudioRenditionSets = AudioRenditionSets;
            this.M3u8Settings = M3u8Settings;
        }
    }
}
