// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html
    /// </summary>
    [AwsNativeResourceType("aws-native:codedeploy:DeploymentGroup")]
    public partial class DeploymentGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-alarmconfiguration
        /// </summary>
        [Output("alarmConfiguration")]
        public Output<Outputs.DeploymentGroupAlarmConfiguration?> AlarmConfiguration { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-applicationname
        /// </summary>
        [Output("applicationName")]
        public Output<string> ApplicationName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autorollbackconfiguration
        /// </summary>
        [Output("autoRollbackConfiguration")]
        public Output<Outputs.DeploymentGroupAutoRollbackConfiguration?> AutoRollbackConfiguration { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autoscalinggroups
        /// </summary>
        [Output("autoScalingGroups")]
        public Output<ImmutableArray<string>> AutoScalingGroups { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration
        /// </summary>
        [Output("blueGreenDeploymentConfiguration")]
        public Output<Outputs.DeploymentGroupBlueGreenDeploymentConfiguration?> BlueGreenDeploymentConfiguration { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deployment
        /// </summary>
        [Output("deployment")]
        public Output<Outputs.DeploymentGroupDeployment?> Deployment { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentconfigname
        /// </summary>
        [Output("deploymentConfigName")]
        public Output<string?> DeploymentConfigName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentgroupname
        /// </summary>
        [Output("deploymentGroupName")]
        public Output<string?> DeploymentGroupName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentstyle
        /// </summary>
        [Output("deploymentStyle")]
        public Output<Outputs.DeploymentGroupDeploymentStyle?> DeploymentStyle { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ecsservices
        /// </summary>
        [Output("eCSServices")]
        public Output<ImmutableArray<Outputs.DeploymentGroupECSService>> ECSServices { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagfilters
        /// </summary>
        [Output("ec2TagFilters")]
        public Output<ImmutableArray<Outputs.DeploymentGroupEC2TagFilter>> Ec2TagFilters { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagset
        /// </summary>
        [Output("ec2TagSet")]
        public Output<Outputs.DeploymentGroupEC2TagSet?> Ec2TagSet { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo
        /// </summary>
        [Output("loadBalancerInfo")]
        public Output<Outputs.DeploymentGroupLoadBalancerInfo?> LoadBalancerInfo { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisesinstancetagfilters
        /// </summary>
        [Output("onPremisesInstanceTagFilters")]
        public Output<ImmutableArray<Outputs.DeploymentGroupTagFilter>> OnPremisesInstanceTagFilters { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisestagset
        /// </summary>
        [Output("onPremisesTagSet")]
        public Output<Outputs.DeploymentGroupOnPremisesTagSet?> OnPremisesTagSet { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-servicerolearn
        /// </summary>
        [Output("serviceRoleArn")]
        public Output<string> ServiceRoleArn { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-triggerconfigurations
        /// </summary>
        [Output("triggerConfigurations")]
        public Output<ImmutableArray<Outputs.DeploymentGroupTriggerConfig>> TriggerConfigurations { get; private set; } = null!;


        /// <summary>
        /// Create a DeploymentGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeploymentGroup(string name, DeploymentGroupArgs args, CustomResourceOptions? options = null)
            : base("aws-native:codedeploy:DeploymentGroup", name, args ?? new DeploymentGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeploymentGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:codedeploy:DeploymentGroup", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DeploymentGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeploymentGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DeploymentGroup(name, id, options);
        }
    }

    public sealed class DeploymentGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-alarmconfiguration
        /// </summary>
        [Input("alarmConfiguration")]
        public Input<Inputs.DeploymentGroupAlarmConfigurationArgs>? AlarmConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-applicationname
        /// </summary>
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autorollbackconfiguration
        /// </summary>
        [Input("autoRollbackConfiguration")]
        public Input<Inputs.DeploymentGroupAutoRollbackConfigurationArgs>? AutoRollbackConfiguration { get; set; }

        [Input("autoScalingGroups")]
        private InputList<string>? _autoScalingGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autoscalinggroups
        /// </summary>
        public InputList<string> AutoScalingGroups
        {
            get => _autoScalingGroups ?? (_autoScalingGroups = new InputList<string>());
            set => _autoScalingGroups = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration
        /// </summary>
        [Input("blueGreenDeploymentConfiguration")]
        public Input<Inputs.DeploymentGroupBlueGreenDeploymentConfigurationArgs>? BlueGreenDeploymentConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deployment
        /// </summary>
        [Input("deployment")]
        public Input<Inputs.DeploymentGroupDeploymentArgs>? Deployment { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentconfigname
        /// </summary>
        [Input("deploymentConfigName")]
        public Input<string>? DeploymentConfigName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentgroupname
        /// </summary>
        [Input("deploymentGroupName")]
        public Input<string>? DeploymentGroupName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentstyle
        /// </summary>
        [Input("deploymentStyle")]
        public Input<Inputs.DeploymentGroupDeploymentStyleArgs>? DeploymentStyle { get; set; }

        [Input("eCSServices")]
        private InputList<Inputs.DeploymentGroupECSServiceArgs>? _eCSServices;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ecsservices
        /// </summary>
        public InputList<Inputs.DeploymentGroupECSServiceArgs> ECSServices
        {
            get => _eCSServices ?? (_eCSServices = new InputList<Inputs.DeploymentGroupECSServiceArgs>());
            set => _eCSServices = value;
        }

        [Input("ec2TagFilters")]
        private InputList<Inputs.DeploymentGroupEC2TagFilterArgs>? _ec2TagFilters;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagfilters
        /// </summary>
        public InputList<Inputs.DeploymentGroupEC2TagFilterArgs> Ec2TagFilters
        {
            get => _ec2TagFilters ?? (_ec2TagFilters = new InputList<Inputs.DeploymentGroupEC2TagFilterArgs>());
            set => _ec2TagFilters = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagset
        /// </summary>
        [Input("ec2TagSet")]
        public Input<Inputs.DeploymentGroupEC2TagSetArgs>? Ec2TagSet { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo
        /// </summary>
        [Input("loadBalancerInfo")]
        public Input<Inputs.DeploymentGroupLoadBalancerInfoArgs>? LoadBalancerInfo { get; set; }

        [Input("onPremisesInstanceTagFilters")]
        private InputList<Inputs.DeploymentGroupTagFilterArgs>? _onPremisesInstanceTagFilters;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisesinstancetagfilters
        /// </summary>
        public InputList<Inputs.DeploymentGroupTagFilterArgs> OnPremisesInstanceTagFilters
        {
            get => _onPremisesInstanceTagFilters ?? (_onPremisesInstanceTagFilters = new InputList<Inputs.DeploymentGroupTagFilterArgs>());
            set => _onPremisesInstanceTagFilters = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisestagset
        /// </summary>
        [Input("onPremisesTagSet")]
        public Input<Inputs.DeploymentGroupOnPremisesTagSetArgs>? OnPremisesTagSet { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-servicerolearn
        /// </summary>
        [Input("serviceRoleArn", required: true)]
        public Input<string> ServiceRoleArn { get; set; } = null!;

        [Input("triggerConfigurations")]
        private InputList<Inputs.DeploymentGroupTriggerConfigArgs>? _triggerConfigurations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-triggerconfigurations
        /// </summary>
        public InputList<Inputs.DeploymentGroupTriggerConfigArgs> TriggerConfigurations
        {
            get => _triggerConfigurations ?? (_triggerConfigurations = new InputList<Inputs.DeploymentGroupTriggerConfigArgs>());
            set => _triggerConfigurations = value;
        }

        public DeploymentGroupArgs()
        {
        }
    }
}