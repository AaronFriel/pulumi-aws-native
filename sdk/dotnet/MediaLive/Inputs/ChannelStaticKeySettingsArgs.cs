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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html
    /// </summary>
    public sealed class ChannelStaticKeySettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-keyproviderserver
        /// </summary>
        [Input("KeyProviderServer")]
        public Input<Inputs.ChannelInputLocationArgs>? KeyProviderServer { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-statickeyvalue
        /// </summary>
        [Input("StaticKeyValue")]
        public Input<string>? StaticKeyValue { get; set; }

        public ChannelStaticKeySettingsArgs()
        {
        }
    }
}
