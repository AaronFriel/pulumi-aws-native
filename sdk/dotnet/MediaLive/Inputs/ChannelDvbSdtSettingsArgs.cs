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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html
    /// </summary>
    public sealed class ChannelDvbSdtSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-outputsdt
        /// </summary>
        [Input("OutputSdt")]
        public Input<string>? OutputSdt { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-repinterval
        /// </summary>
        [Input("RepInterval")]
        public Input<int>? RepInterval { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-servicename
        /// </summary>
        [Input("ServiceName")]
        public Input<string>? ServiceName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-serviceprovidername
        /// </summary>
        [Input("ServiceProviderName")]
        public Input<string>? ServiceProviderName { get; set; }

        public ChannelDvbSdtSettingsArgs()
        {
        }
    }
}
