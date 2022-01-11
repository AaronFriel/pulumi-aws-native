// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelBurnInDestinationSettings
    {
        public readonly string? Alignment;
        public readonly string? BackgroundColor;
        public readonly int? BackgroundOpacity;
        public readonly Outputs.ChannelInputLocation? Font;
        public readonly string? FontColor;
        public readonly int? FontOpacity;
        public readonly int? FontResolution;
        public readonly string? FontSize;
        public readonly string? OutlineColor;
        public readonly int? OutlineSize;
        public readonly string? ShadowColor;
        public readonly int? ShadowOpacity;
        public readonly int? ShadowXOffset;
        public readonly int? ShadowYOffset;
        public readonly string? TeletextGridControl;
        public readonly int? XPosition;
        public readonly int? YPosition;

        [OutputConstructor]
        private ChannelBurnInDestinationSettings(
            string? alignment,

            string? backgroundColor,

            int? backgroundOpacity,

            Outputs.ChannelInputLocation? font,

            string? fontColor,

            int? fontOpacity,

            int? fontResolution,

            string? fontSize,

            string? outlineColor,

            int? outlineSize,

            string? shadowColor,

            int? shadowOpacity,

            int? shadowXOffset,

            int? shadowYOffset,

            string? teletextGridControl,

            int? xPosition,

            int? yPosition)
        {
            Alignment = alignment;
            BackgroundColor = backgroundColor;
            BackgroundOpacity = backgroundOpacity;
            Font = font;
            FontColor = fontColor;
            FontOpacity = fontOpacity;
            FontResolution = fontResolution;
            FontSize = fontSize;
            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
            ShadowColor = shadowColor;
            ShadowOpacity = shadowOpacity;
            ShadowXOffset = shadowXOffset;
            ShadowYOffset = shadowYOffset;
            TeletextGridControl = teletextGridControl;
            XPosition = xPosition;
            YPosition = yPosition;
        }
    }
}
