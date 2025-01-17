// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    public sealed class ChannelMotionGraphicsConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("motionGraphicsInsertion")]
        public Input<string>? MotionGraphicsInsertion { get; set; }

        [Input("motionGraphicsSettings")]
        public Input<Inputs.ChannelMotionGraphicsSettingsArgs>? MotionGraphicsSettings { get; set; }

        public ChannelMotionGraphicsConfigurationArgs()
        {
        }
    }
}
