// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Outputs
{

    [OutputType]
    public sealed class CapacityProviderAutoScalingGroupProvider
    {
        public readonly string AutoScalingGroupArn;
        public readonly Outputs.CapacityProviderManagedScaling? ManagedScaling;
        public readonly string? ManagedTerminationProtection;

        [OutputConstructor]
        private CapacityProviderAutoScalingGroupProvider(
            string autoScalingGroupArn,

            Outputs.CapacityProviderManagedScaling? managedScaling,

            string? managedTerminationProtection)
        {
            AutoScalingGroupArn = autoScalingGroupArn;
            ManagedScaling = managedScaling;
            ManagedTerminationProtection = managedTerminationProtection;
        }
    }
}
