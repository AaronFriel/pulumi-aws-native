// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    /// <summary>
    /// The managed scaling settings for the Auto Scaling group capacity provider.
    /// </summary>
    public sealed class CapacityProviderManagedScalingArgs : Pulumi.ResourceArgs
    {
        [Input("instanceWarmupPeriod")]
        public Input<int>? InstanceWarmupPeriod { get; set; }

        [Input("maximumScalingStepSize")]
        public Input<int>? MaximumScalingStepSize { get; set; }

        [Input("minimumScalingStepSize")]
        public Input<int>? MinimumScalingStepSize { get; set; }

        [Input("status")]
        public Input<Pulumi.AwsNative.ECS.CapacityProviderManagedScalingStatus>? Status { get; set; }

        [Input("targetCapacity")]
        public Input<int>? TargetCapacity { get; set; }

        public CapacityProviderManagedScalingArgs()
        {
        }
    }
}
