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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html
    /// </summary>
    public sealed class ChannelBurnInDestinationSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-alignment
        /// </summary>
        [Input("Alignment")]
        public Input<string>? Alignment { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundcolor
        /// </summary>
        [Input("BackgroundColor")]
        public Input<string>? BackgroundColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundopacity
        /// </summary>
        [Input("BackgroundOpacity")]
        public Input<int>? BackgroundOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-font
        /// </summary>
        [Input("Font")]
        public Input<Inputs.ChannelInputLocationArgs>? Font { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontcolor
        /// </summary>
        [Input("FontColor")]
        public Input<string>? FontColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontopacity
        /// </summary>
        [Input("FontOpacity")]
        public Input<int>? FontOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontresolution
        /// </summary>
        [Input("FontResolution")]
        public Input<int>? FontResolution { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontsize
        /// </summary>
        [Input("FontSize")]
        public Input<string>? FontSize { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinecolor
        /// </summary>
        [Input("OutlineColor")]
        public Input<string>? OutlineColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinesize
        /// </summary>
        [Input("OutlineSize")]
        public Input<int>? OutlineSize { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowcolor
        /// </summary>
        [Input("ShadowColor")]
        public Input<string>? ShadowColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowopacity
        /// </summary>
        [Input("ShadowOpacity")]
        public Input<int>? ShadowOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowxoffset
        /// </summary>
        [Input("ShadowXOffset")]
        public Input<int>? ShadowXOffset { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowyoffset
        /// </summary>
        [Input("ShadowYOffset")]
        public Input<int>? ShadowYOffset { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-teletextgridcontrol
        /// </summary>
        [Input("TeletextGridControl")]
        public Input<string>? TeletextGridControl { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-xposition
        /// </summary>
        [Input("XPosition")]
        public Input<int>? XPosition { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-yposition
        /// </summary>
        [Input("YPosition")]
        public Input<int>? YPosition { get; set; }

        public ChannelBurnInDestinationSettingsArgs()
        {
        }
    }
}
