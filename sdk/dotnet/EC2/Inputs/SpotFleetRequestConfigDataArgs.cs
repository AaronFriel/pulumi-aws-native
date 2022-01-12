// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class SpotFleetRequestConfigDataArgs : Pulumi.ResourceArgs
    {
        [Input("allocationStrategy")]
        public Input<Pulumi.AwsNative.EC2.SpotFleetRequestConfigDataAllocationStrategy>? AllocationStrategy { get; set; }

        [Input("context")]
        public Input<string>? Context { get; set; }

        [Input("excessCapacityTerminationPolicy")]
        public Input<Pulumi.AwsNative.EC2.SpotFleetRequestConfigDataExcessCapacityTerminationPolicy>? ExcessCapacityTerminationPolicy { get; set; }

        [Input("iamFleetRole", required: true)]
        public Input<string> IamFleetRole { get; set; } = null!;

        [Input("instanceInterruptionBehavior")]
        public Input<Pulumi.AwsNative.EC2.SpotFleetRequestConfigDataInstanceInterruptionBehavior>? InstanceInterruptionBehavior { get; set; }

        [Input("instancePoolsToUseCount")]
        public Input<int>? InstancePoolsToUseCount { get; set; }

        [Input("launchSpecifications")]
        private InputList<Inputs.SpotFleetLaunchSpecificationArgs>? _launchSpecifications;
        public InputList<Inputs.SpotFleetLaunchSpecificationArgs> LaunchSpecifications
        {
            get => _launchSpecifications ?? (_launchSpecifications = new InputList<Inputs.SpotFleetLaunchSpecificationArgs>());
            set => _launchSpecifications = value;
        }

        [Input("launchTemplateConfigs")]
        private InputList<Inputs.SpotFleetLaunchTemplateConfigArgs>? _launchTemplateConfigs;
        public InputList<Inputs.SpotFleetLaunchTemplateConfigArgs> LaunchTemplateConfigs
        {
            get => _launchTemplateConfigs ?? (_launchTemplateConfigs = new InputList<Inputs.SpotFleetLaunchTemplateConfigArgs>());
            set => _launchTemplateConfigs = value;
        }

        [Input("loadBalancersConfig")]
        public Input<Inputs.SpotFleetLoadBalancersConfigArgs>? LoadBalancersConfig { get; set; }

        [Input("onDemandAllocationStrategy")]
        public Input<string>? OnDemandAllocationStrategy { get; set; }

        [Input("onDemandMaxTotalPrice")]
        public Input<string>? OnDemandMaxTotalPrice { get; set; }

        [Input("onDemandTargetCapacity")]
        public Input<int>? OnDemandTargetCapacity { get; set; }

        [Input("replaceUnhealthyInstances")]
        public Input<bool>? ReplaceUnhealthyInstances { get; set; }

        [Input("spotMaintenanceStrategies")]
        public Input<Inputs.SpotFleetSpotMaintenanceStrategiesArgs>? SpotMaintenanceStrategies { get; set; }

        [Input("spotMaxTotalPrice")]
        public Input<string>? SpotMaxTotalPrice { get; set; }

        [Input("spotPrice")]
        public Input<string>? SpotPrice { get; set; }

        [Input("targetCapacity", required: true)]
        public Input<int> TargetCapacity { get; set; } = null!;

        [Input("targetCapacityUnitType")]
        public Input<Pulumi.AwsNative.EC2.SpotFleetRequestConfigDataTargetCapacityUnitType>? TargetCapacityUnitType { get; set; }

        [Input("terminateInstancesWithExpiration")]
        public Input<bool>? TerminateInstancesWithExpiration { get; set; }

        [Input("type")]
        public Input<Pulumi.AwsNative.EC2.SpotFleetRequestConfigDataType>? Type { get; set; }

        [Input("validFrom")]
        public Input<string>? ValidFrom { get; set; }

        [Input("validUntil")]
        public Input<string>? ValidUntil { get; set; }

        public SpotFleetRequestConfigDataArgs()
        {
        }
    }
}
