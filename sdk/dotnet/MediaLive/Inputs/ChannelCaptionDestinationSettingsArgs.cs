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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html
    /// </summary>
    public sealed class ChannelCaptionDestinationSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-aribdestinationsettings
        /// </summary>
        [Input("AribDestinationSettings")]
        public Input<Inputs.ChannelAribDestinationSettingsArgs>? AribDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-burnindestinationsettings
        /// </summary>
        [Input("BurnInDestinationSettings")]
        public Input<Inputs.ChannelBurnInDestinationSettingsArgs>? BurnInDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-dvbsubdestinationsettings
        /// </summary>
        [Input("DvbSubDestinationSettings")]
        public Input<Inputs.ChannelDvbSubDestinationSettingsArgs>? DvbSubDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ebuttddestinationsettings
        /// </summary>
        [Input("EbuTtDDestinationSettings")]
        public Input<Inputs.ChannelEbuTtDDestinationSettingsArgs>? EbuTtDDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddeddestinationsettings
        /// </summary>
        [Input("EmbeddedDestinationSettings")]
        public Input<Inputs.ChannelEmbeddedDestinationSettingsArgs>? EmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddedplusscte20destinationsettings
        /// </summary>
        [Input("EmbeddedPlusScte20DestinationSettings")]
        public Input<Inputs.ChannelEmbeddedPlusScte20DestinationSettingsArgs>? EmbeddedPlusScte20DestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-rtmpcaptioninfodestinationsettings
        /// </summary>
        [Input("RtmpCaptionInfoDestinationSettings")]
        public Input<Inputs.ChannelRtmpCaptionInfoDestinationSettingsArgs>? RtmpCaptionInfoDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte20plusembeddeddestinationsettings
        /// </summary>
        [Input("Scte20PlusEmbeddedDestinationSettings")]
        public Input<Inputs.ChannelScte20PlusEmbeddedDestinationSettingsArgs>? Scte20PlusEmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte27destinationsettings
        /// </summary>
        [Input("Scte27DestinationSettings")]
        public Input<Inputs.ChannelScte27DestinationSettingsArgs>? Scte27DestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-smptettdestinationsettings
        /// </summary>
        [Input("SmpteTtDestinationSettings")]
        public Input<Inputs.ChannelSmpteTtDestinationSettingsArgs>? SmpteTtDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-teletextdestinationsettings
        /// </summary>
        [Input("TeletextDestinationSettings")]
        public Input<Inputs.ChannelTeletextDestinationSettingsArgs>? TeletextDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ttmldestinationsettings
        /// </summary>
        [Input("TtmlDestinationSettings")]
        public Input<Inputs.ChannelTtmlDestinationSettingsArgs>? TtmlDestinationSettings { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-webvttdestinationsettings
        /// </summary>
        [Input("WebvttDestinationSettings")]
        public Input<Inputs.ChannelWebvttDestinationSettingsArgs>? WebvttDestinationSettings { get; set; }

        public ChannelCaptionDestinationSettingsArgs()
        {
        }
    }
}
