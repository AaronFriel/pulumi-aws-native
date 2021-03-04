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
    public sealed class ChannelArchiveGroupSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-destination
        /// </summary>
        public readonly Outputs.ChannelOutputLocationRef? Destination;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-rolloverinterval
        /// </summary>
        public readonly int? RolloverInterval;

        [OutputConstructor]
        private ChannelArchiveGroupSettings(
            Outputs.ChannelOutputLocationRef? Destination,

            int? RolloverInterval)
        {
            this.Destination = Destination;
            this.RolloverInterval = RolloverInterval;
        }
    }
}
