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
    public sealed class ChannelEmbeddedSourceSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-convert608to708
        /// </summary>
        public readonly string? Convert608To708;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-scte20detection
        /// </summary>
        public readonly string? Scte20Detection;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608channelnumber
        /// </summary>
        public readonly int? Source608ChannelNumber;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608tracknumber
        /// </summary>
        public readonly int? Source608TrackNumber;

        [OutputConstructor]
        private ChannelEmbeddedSourceSettings(
            string? Convert608To708,

            string? Scte20Detection,

            int? Source608ChannelNumber,

            int? Source608TrackNumber)
        {
            this.Convert608To708 = Convert608To708;
            this.Scte20Detection = Scte20Detection;
            this.Source608ChannelNumber = Source608ChannelNumber;
            this.Source608TrackNumber = Source608TrackNumber;
        }
    }
}
