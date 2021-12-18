// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class ClusterCapacityProviderAssociationsCapacityProviderStrategyArgs : Pulumi.ResourceArgs
    {
        [Input("base")]
        public Input<int>? Base { get; set; }

        [Input("capacityProvider", required: true)]
        public InputUnion<Pulumi.AwsNative.ECS.ClusterCapacityProviderAssociationsCapacityProvider, string> CapacityProvider { get; set; } = null!;

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public ClusterCapacityProviderAssociationsCapacityProviderStrategyArgs()
        {
        }
    }
}
