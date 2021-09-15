// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Inputs
{

    public sealed class ConfigAntennaDownlinkDemodDecodeConfigArgs : Pulumi.ResourceArgs
    {
        [Input("decodeConfig")]
        public Input<Inputs.ConfigDecodeConfigArgs>? DecodeConfig { get; set; }

        [Input("demodulationConfig")]
        public Input<Inputs.ConfigDemodulationConfigArgs>? DemodulationConfig { get; set; }

        [Input("spectrumConfig")]
        public Input<Inputs.ConfigSpectrumConfigArgs>? SpectrumConfig { get; set; }

        public ConfigAntennaDownlinkDemodDecodeConfigArgs()
        {
        }
    }
}
