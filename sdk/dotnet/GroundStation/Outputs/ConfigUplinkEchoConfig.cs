// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Outputs
{

    [OutputType]
    public sealed class ConfigUplinkEchoConfig
    {
        public readonly string? AntennaUplinkConfigArn;
        public readonly bool? Enabled;

        [OutputConstructor]
        private ConfigUplinkEchoConfig(
            string? antennaUplinkConfigArn,

            bool? enabled)
        {
            AntennaUplinkConfigArn = antennaUplinkConfigArn;
            Enabled = enabled;
        }
    }
}
