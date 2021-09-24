// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    public sealed class ChannelEncoderSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("audioDescriptions")]
        private InputList<Inputs.ChannelAudioDescriptionArgs>? _audioDescriptions;
        public InputList<Inputs.ChannelAudioDescriptionArgs> AudioDescriptions
        {
            get => _audioDescriptions ?? (_audioDescriptions = new InputList<Inputs.ChannelAudioDescriptionArgs>());
            set => _audioDescriptions = value;
        }

        [Input("availBlanking")]
        public Input<Inputs.ChannelAvailBlankingArgs>? AvailBlanking { get; set; }

        [Input("availConfiguration")]
        public Input<Inputs.ChannelAvailConfigurationArgs>? AvailConfiguration { get; set; }

        [Input("blackoutSlate")]
        public Input<Inputs.ChannelBlackoutSlateArgs>? BlackoutSlate { get; set; }

        [Input("captionDescriptions")]
        private InputList<Inputs.ChannelCaptionDescriptionArgs>? _captionDescriptions;
        public InputList<Inputs.ChannelCaptionDescriptionArgs> CaptionDescriptions
        {
            get => _captionDescriptions ?? (_captionDescriptions = new InputList<Inputs.ChannelCaptionDescriptionArgs>());
            set => _captionDescriptions = value;
        }

        [Input("featureActivations")]
        public Input<Inputs.ChannelFeatureActivationsArgs>? FeatureActivations { get; set; }

        [Input("globalConfiguration")]
        public Input<Inputs.ChannelGlobalConfigurationArgs>? GlobalConfiguration { get; set; }

        [Input("motionGraphicsConfiguration")]
        public Input<Inputs.ChannelMotionGraphicsConfigurationArgs>? MotionGraphicsConfiguration { get; set; }

        [Input("nielsenConfiguration")]
        public Input<Inputs.ChannelNielsenConfigurationArgs>? NielsenConfiguration { get; set; }

        [Input("outputGroups")]
        private InputList<Inputs.ChannelOutputGroupArgs>? _outputGroups;
        public InputList<Inputs.ChannelOutputGroupArgs> OutputGroups
        {
            get => _outputGroups ?? (_outputGroups = new InputList<Inputs.ChannelOutputGroupArgs>());
            set => _outputGroups = value;
        }

        [Input("timecodeConfig")]
        public Input<Inputs.ChannelTimecodeConfigArgs>? TimecodeConfig { get; set; }

        [Input("videoDescriptions")]
        private InputList<Inputs.ChannelVideoDescriptionArgs>? _videoDescriptions;
        public InputList<Inputs.ChannelVideoDescriptionArgs> VideoDescriptions
        {
            get => _videoDescriptions ?? (_videoDescriptions = new InputList<Inputs.ChannelVideoDescriptionArgs>());
            set => _videoDescriptions = value;
        }

        public ChannelEncoderSettingsArgs()
        {
        }
    }
}