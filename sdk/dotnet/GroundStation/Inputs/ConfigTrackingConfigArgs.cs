// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Inputs
{

    public sealed class ConfigTrackingConfigArgs : Pulumi.ResourceArgs
    {
        [Input("autotrack")]
        public Input<string>? Autotrack { get; set; }

        public ConfigTrackingConfigArgs()
        {
        }
    }
}
