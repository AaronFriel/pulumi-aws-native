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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html
    /// </summary>
    public sealed class ChannelDvbSubSourceSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html#cfn-medialive-channel-dvbsubsourcesettings-pid
        /// </summary>
        [Input("Pid")]
        public Input<int>? Pid { get; set; }

        public ChannelDvbSubSourceSettingsArgs()
        {
        }
    }
}
