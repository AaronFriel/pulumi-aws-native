// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Pinpoint.Outputs
{

    [OutputType]
    public sealed class CampaignDefaultButtonConfiguration
    {
        public readonly string? BackgroundColor;
        public readonly int? BorderRadius;
        public readonly string? ButtonAction;
        public readonly string? Link;
        public readonly string? Text;
        public readonly string? TextColor;

        [OutputConstructor]
        private CampaignDefaultButtonConfiguration(
            string? backgroundColor,

            int? borderRadius,

            string? buttonAction,

            string? link,

            string? text,

            string? textColor)
        {
            BackgroundColor = backgroundColor;
            BorderRadius = borderRadius;
            ButtonAction = buttonAction;
            Link = link;
            Text = text;
            TextColor = textColor;
        }
    }
}
