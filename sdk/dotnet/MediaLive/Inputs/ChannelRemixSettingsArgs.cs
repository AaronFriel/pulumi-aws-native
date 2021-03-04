// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html
    /// </summary>
    public sealed class ChannelRemixSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("ChannelMappings")]
        private InputList<Inputs.ChannelAudioChannelMappingArgs>? _ChannelMappings;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelmappings
        /// </summary>
        public InputList<Inputs.ChannelAudioChannelMappingArgs> ChannelMappings
        {
            get => _ChannelMappings ?? (_ChannelMappings = new InputList<Inputs.ChannelAudioChannelMappingArgs>());
            set => _ChannelMappings = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsin
        /// </summary>
        [Input("ChannelsIn")]
        public Input<int>? ChannelsIn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsout
        /// </summary>
        [Input("ChannelsOut")]
        public Input<int>? ChannelsOut { get; set; }

        public ChannelRemixSettingsArgs()
        {
        }
    }
}
