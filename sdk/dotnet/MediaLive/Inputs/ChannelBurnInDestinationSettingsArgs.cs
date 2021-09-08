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
        [Input("alignment")]
        public Input<string>? Alignment { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundcolor
        /// </summary>
        [Input("backgroundColor")]
        public Input<string>? BackgroundColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundopacity
        /// </summary>
        [Input("backgroundOpacity")]
        public Input<int>? BackgroundOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-font
        /// </summary>
        [Input("font")]
        public Input<Inputs.ChannelInputLocationArgs>? Font { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontcolor
        /// </summary>
        [Input("fontColor")]
        public Input<string>? FontColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontopacity
        /// </summary>
        [Input("fontOpacity")]
        public Input<int>? FontOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontresolution
        /// </summary>
        [Input("fontResolution")]
        public Input<int>? FontResolution { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontsize
        /// </summary>
        [Input("fontSize")]
        public Input<string>? FontSize { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinecolor
        /// </summary>
        [Input("outlineColor")]
        public Input<string>? OutlineColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinesize
        /// </summary>
        [Input("outlineSize")]
        public Input<int>? OutlineSize { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowcolor
        /// </summary>
        [Input("shadowColor")]
        public Input<string>? ShadowColor { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowopacity
        /// </summary>
        [Input("shadowOpacity")]
        public Input<int>? ShadowOpacity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowxoffset
        /// </summary>
        [Input("shadowXOffset")]
        public Input<int>? ShadowXOffset { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowyoffset
        /// </summary>
        [Input("shadowYOffset")]
        public Input<int>? ShadowYOffset { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-teletextgridcontrol
        /// </summary>
        [Input("teletextGridControl")]
        public Input<string>? TeletextGridControl { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-xposition
        /// </summary>
        [Input("xPosition")]
        public Input<int>? XPosition { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-yposition
        /// </summary>
        [Input("yPosition")]
        public Input<int>? YPosition { get; set; }

        public ChannelBurnInDestinationSettingsArgs()
        {
        }
    }
}