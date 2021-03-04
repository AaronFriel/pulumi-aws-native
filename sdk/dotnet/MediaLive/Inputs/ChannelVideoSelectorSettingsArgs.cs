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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html
    /// </summary>
    public sealed class ChannelVideoSelectorSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorpid
        /// </summary>
        [Input("VideoSelectorPid")]
        public Input<Inputs.ChannelVideoSelectorPidArgs>? VideoSelectorPid { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorprogramid
        /// </summary>
        [Input("VideoSelectorProgramId")]
        public Input<Inputs.ChannelVideoSelectorProgramIdArgs>? VideoSelectorProgramId { get; set; }

        public ChannelVideoSelectorSettingsArgs()
        {
        }
    }
}
