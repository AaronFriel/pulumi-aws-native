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
    public sealed class ChannelOutputDestination
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-mediapackagesettings
        /// </summary>
        public readonly ImmutableArray<Outputs.ChannelMediaPackageOutputDestinationSettings> MediaPackageSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-multiplexsettings
        /// </summary>
        public readonly Outputs.ChannelMultiplexProgramChannelDestinationSettings? MultiplexSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-settings
        /// </summary>
        public readonly ImmutableArray<Outputs.ChannelOutputDestinationSettings> Settings;

        [OutputConstructor]
        private ChannelOutputDestination(
            string? Id,

            ImmutableArray<Outputs.ChannelMediaPackageOutputDestinationSettings> MediaPackageSettings,

            Outputs.ChannelMultiplexProgramChannelDestinationSettings? MultiplexSettings,

            ImmutableArray<Outputs.ChannelOutputDestinationSettings> Settings)
        {
            this.Id = Id;
            this.MediaPackageSettings = MediaPackageSettings;
            this.MultiplexSettings = MultiplexSettings;
            this.Settings = Settings;
        }
    }
}
