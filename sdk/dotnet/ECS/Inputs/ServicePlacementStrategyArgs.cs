// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class ServicePlacementStrategyArgs : Pulumi.ResourceArgs
    {
        [Input("field")]
        public Input<string>? Field { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ServicePlacementStrategyArgs()
        {
        }
    }
}
