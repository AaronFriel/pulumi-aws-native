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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html
    /// </summary>
    public sealed class ChannelHlsInputSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-bandwidth
        /// </summary>
        [Input("Bandwidth")]
        public Input<int>? Bandwidth { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-buffersegments
        /// </summary>
        [Input("BufferSegments")]
        public Input<int>? BufferSegments { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retries
        /// </summary>
        [Input("Retries")]
        public Input<int>? Retries { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retryinterval
        /// </summary>
        [Input("RetryInterval")]
        public Input<int>? RetryInterval { get; set; }

        public ChannelHlsInputSettingsArgs()
        {
        }
    }
}
