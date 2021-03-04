// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Outputs
{

    [OutputType]
    public sealed class AutoScalingGroupProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-autoscaling-autoscalinggroup-autoscalinggroupname
        /// </summary>
        public readonly string? AutoScalingGroupName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-availabilityzones
        /// </summary>
        public readonly ImmutableArray<string> AvailabilityZones;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-capacityrebalance
        /// </summary>
        public readonly bool? CapacityRebalance;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-cooldown
        /// </summary>
        public readonly string? Cooldown;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-desiredcapacity
        /// </summary>
        public readonly string? DesiredCapacity;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-healthcheckgraceperiod
        /// </summary>
        public readonly int? HealthCheckGracePeriod;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-healthchecktype
        /// </summary>
        public readonly string? HealthCheckType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-instanceid
        /// </summary>
        public readonly string? InstanceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-launchconfigurationname
        /// </summary>
        public readonly string? LaunchConfigurationName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-launchtemplate
        /// </summary>
        public readonly Outputs.AutoScalingGroupLaunchTemplateSpecification? LaunchTemplate;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecificationlist
        /// </summary>
        public readonly ImmutableArray<Outputs.AutoScalingGroupLifecycleHookSpecification> LifecycleHookSpecificationList;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-loadbalancernames
        /// </summary>
        public readonly ImmutableArray<string> LoadBalancerNames;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-maxinstancelifetime
        /// </summary>
        public readonly int? MaxInstanceLifetime;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-maxsize
        /// </summary>
        public readonly string MaxSize;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-metricscollection
        /// </summary>
        public readonly ImmutableArray<Outputs.AutoScalingGroupMetricsCollection> MetricsCollection;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-minsize
        /// </summary>
        public readonly string MinSize;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-mixedinstancespolicy
        /// </summary>
        public readonly Outputs.AutoScalingGroupMixedInstancesPolicy? MixedInstancesPolicy;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-newinstancesprotectedfromscalein
        /// </summary>
        public readonly bool? NewInstancesProtectedFromScaleIn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-notificationconfigurations
        /// </summary>
        public readonly ImmutableArray<Outputs.AutoScalingGroupNotificationConfiguration> NotificationConfigurations;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-placementgroup
        /// </summary>
        public readonly string? PlacementGroup;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-autoscaling-autoscalinggroup-servicelinkedrolearn
        /// </summary>
        public readonly string? ServiceLinkedRoleARN;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-tags
        /// </summary>
        public readonly ImmutableArray<Outputs.AutoScalingGroupTagProperty> Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-targetgrouparns
        /// </summary>
        public readonly ImmutableArray<string> TargetGroupARNs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-termpolicy
        /// </summary>
        public readonly ImmutableArray<string> TerminationPolicies;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-vpczoneidentifier
        /// </summary>
        public readonly ImmutableArray<string> VPCZoneIdentifier;

        [OutputConstructor]
        private AutoScalingGroupProperties(
            string? AutoScalingGroupName,

            ImmutableArray<string> AvailabilityZones,

            bool? CapacityRebalance,

            string? Cooldown,

            string? DesiredCapacity,

            int? HealthCheckGracePeriod,

            string? HealthCheckType,

            string? InstanceId,

            string? LaunchConfigurationName,

            Outputs.AutoScalingGroupLaunchTemplateSpecification? LaunchTemplate,

            ImmutableArray<Outputs.AutoScalingGroupLifecycleHookSpecification> LifecycleHookSpecificationList,

            ImmutableArray<string> LoadBalancerNames,

            int? MaxInstanceLifetime,

            string MaxSize,

            ImmutableArray<Outputs.AutoScalingGroupMetricsCollection> MetricsCollection,

            string MinSize,

            Outputs.AutoScalingGroupMixedInstancesPolicy? MixedInstancesPolicy,

            bool? NewInstancesProtectedFromScaleIn,

            ImmutableArray<Outputs.AutoScalingGroupNotificationConfiguration> NotificationConfigurations,

            string? PlacementGroup,

            string? ServiceLinkedRoleARN,

            ImmutableArray<Outputs.AutoScalingGroupTagProperty> Tags,

            ImmutableArray<string> TargetGroupARNs,

            ImmutableArray<string> TerminationPolicies,

            ImmutableArray<string> VPCZoneIdentifier)
        {
            this.AutoScalingGroupName = AutoScalingGroupName;
            this.AvailabilityZones = AvailabilityZones;
            this.CapacityRebalance = CapacityRebalance;
            this.Cooldown = Cooldown;
            this.DesiredCapacity = DesiredCapacity;
            this.HealthCheckGracePeriod = HealthCheckGracePeriod;
            this.HealthCheckType = HealthCheckType;
            this.InstanceId = InstanceId;
            this.LaunchConfigurationName = LaunchConfigurationName;
            this.LaunchTemplate = LaunchTemplate;
            this.LifecycleHookSpecificationList = LifecycleHookSpecificationList;
            this.LoadBalancerNames = LoadBalancerNames;
            this.MaxInstanceLifetime = MaxInstanceLifetime;
            this.MaxSize = MaxSize;
            this.MetricsCollection = MetricsCollection;
            this.MinSize = MinSize;
            this.MixedInstancesPolicy = MixedInstancesPolicy;
            this.NewInstancesProtectedFromScaleIn = NewInstancesProtectedFromScaleIn;
            this.NotificationConfigurations = NotificationConfigurations;
            this.PlacementGroup = PlacementGroup;
            this.ServiceLinkedRoleARN = ServiceLinkedRoleARN;
            this.Tags = Tags;
            this.TargetGroupARNs = TargetGroupARNs;
            this.TerminationPolicies = TerminationPolicies;
            this.VPCZoneIdentifier = VPCZoneIdentifier;
        }
    }
}
