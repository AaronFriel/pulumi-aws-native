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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html
    /// </summary>
    public sealed class ChannelOutputDestinationSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-passwordparam
        /// </summary>
        [Input("PasswordParam")]
        public Input<string>? PasswordParam { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-streamname
        /// </summary>
        [Input("StreamName")]
        public Input<string>? StreamName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-url
        /// </summary>
        [Input("Url")]
        public Input<string>? Url { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-username
        /// </summary>
        [Input("Username")]
        public Input<string>? Username { get; set; }

        public ChannelOutputDestinationSettingsArgs()
        {
        }
    }
}
