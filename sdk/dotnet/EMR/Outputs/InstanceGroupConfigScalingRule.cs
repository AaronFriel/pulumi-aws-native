// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Outputs
{

    [OutputType]
    public sealed class InstanceGroupConfigScalingRule
    {
        public readonly Outputs.InstanceGroupConfigScalingAction Action;
        public readonly string? Description;
        public readonly string Name;
        public readonly Outputs.InstanceGroupConfigScalingTrigger Trigger;

        [OutputConstructor]
        private InstanceGroupConfigScalingRule(
            Outputs.InstanceGroupConfigScalingAction action,

            string? description,

            string name,

            Outputs.InstanceGroupConfigScalingTrigger trigger)
        {
            Action = action;
            Description = description;
            Name = name;
            Trigger = trigger;
        }
    }
}
