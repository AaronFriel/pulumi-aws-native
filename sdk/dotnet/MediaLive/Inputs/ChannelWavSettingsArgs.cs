// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    public sealed class ChannelWavSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("bitDepth")]
        public Input<double>? BitDepth { get; set; }

        [Input("codingMode")]
        public Input<string>? CodingMode { get; set; }

        [Input("sampleRate")]
        public Input<double>? SampleRate { get; set; }

        public ChannelWavSettingsArgs()
        {
        }
    }
}
