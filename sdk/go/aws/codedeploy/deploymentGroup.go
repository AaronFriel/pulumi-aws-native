// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codedeploy

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::CodeDeploy::DeploymentGroup
//
// Deprecated: DeploymentGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type DeploymentGroup struct {
	pulumi.CustomResourceState

	AlarmConfiguration               DeploymentGroupAlarmConfigurationPtrOutput               `pulumi:"alarmConfiguration"`
	ApplicationName                  pulumi.StringOutput                                      `pulumi:"applicationName"`
	AutoRollbackConfiguration        DeploymentGroupAutoRollbackConfigurationPtrOutput        `pulumi:"autoRollbackConfiguration"`
	AutoScalingGroups                pulumi.StringArrayOutput                                 `pulumi:"autoScalingGroups"`
	BlueGreenDeploymentConfiguration DeploymentGroupBlueGreenDeploymentConfigurationPtrOutput `pulumi:"blueGreenDeploymentConfiguration"`
	Deployment                       DeploymentGroupDeploymentPtrOutput                       `pulumi:"deployment"`
	DeploymentConfigName             pulumi.StringPtrOutput                                   `pulumi:"deploymentConfigName"`
	DeploymentGroupName              pulumi.StringPtrOutput                                   `pulumi:"deploymentGroupName"`
	DeploymentStyle                  DeploymentGroupDeploymentStylePtrOutput                  `pulumi:"deploymentStyle"`
	ECSServices                      DeploymentGroupECSServiceArrayOutput                     `pulumi:"eCSServices"`
	Ec2TagFilters                    DeploymentGroupEC2TagFilterArrayOutput                   `pulumi:"ec2TagFilters"`
	Ec2TagSet                        DeploymentGroupEC2TagSetPtrOutput                        `pulumi:"ec2TagSet"`
	LoadBalancerInfo                 DeploymentGroupLoadBalancerInfoPtrOutput                 `pulumi:"loadBalancerInfo"`
	OnPremisesInstanceTagFilters     DeploymentGroupTagFilterArrayOutput                      `pulumi:"onPremisesInstanceTagFilters"`
	OnPremisesTagSet                 DeploymentGroupOnPremisesTagSetPtrOutput                 `pulumi:"onPremisesTagSet"`
	ServiceRoleArn                   pulumi.StringOutput                                      `pulumi:"serviceRoleArn"`
	TriggerConfigurations            DeploymentGroupTriggerConfigArrayOutput                  `pulumi:"triggerConfigurations"`
}

// NewDeploymentGroup registers a new resource with the given unique name, arguments, and options.
func NewDeploymentGroup(ctx *pulumi.Context,
	name string, args *DeploymentGroupArgs, opts ...pulumi.ResourceOption) (*DeploymentGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApplicationName == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationName'")
	}
	if args.ServiceRoleArn == nil {
		return nil, errors.New("invalid value for required argument 'ServiceRoleArn'")
	}
	var resource DeploymentGroup
	err := ctx.RegisterResource("aws-native:codedeploy:DeploymentGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeploymentGroup gets an existing DeploymentGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeploymentGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeploymentGroupState, opts ...pulumi.ResourceOption) (*DeploymentGroup, error) {
	var resource DeploymentGroup
	err := ctx.ReadResource("aws-native:codedeploy:DeploymentGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeploymentGroup resources.
type deploymentGroupState struct {
}

type DeploymentGroupState struct {
}

func (DeploymentGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentGroupState)(nil)).Elem()
}

type deploymentGroupArgs struct {
	AlarmConfiguration               *DeploymentGroupAlarmConfiguration               `pulumi:"alarmConfiguration"`
	ApplicationName                  string                                           `pulumi:"applicationName"`
	AutoRollbackConfiguration        *DeploymentGroupAutoRollbackConfiguration        `pulumi:"autoRollbackConfiguration"`
	AutoScalingGroups                []string                                         `pulumi:"autoScalingGroups"`
	BlueGreenDeploymentConfiguration *DeploymentGroupBlueGreenDeploymentConfiguration `pulumi:"blueGreenDeploymentConfiguration"`
	Deployment                       *DeploymentGroupDeployment                       `pulumi:"deployment"`
	DeploymentConfigName             *string                                          `pulumi:"deploymentConfigName"`
	DeploymentGroupName              *string                                          `pulumi:"deploymentGroupName"`
	DeploymentStyle                  *DeploymentGroupDeploymentStyle                  `pulumi:"deploymentStyle"`
	ECSServices                      []DeploymentGroupECSService                      `pulumi:"eCSServices"`
	Ec2TagFilters                    []DeploymentGroupEC2TagFilter                    `pulumi:"ec2TagFilters"`
	Ec2TagSet                        *DeploymentGroupEC2TagSet                        `pulumi:"ec2TagSet"`
	LoadBalancerInfo                 *DeploymentGroupLoadBalancerInfo                 `pulumi:"loadBalancerInfo"`
	OnPremisesInstanceTagFilters     []DeploymentGroupTagFilter                       `pulumi:"onPremisesInstanceTagFilters"`
	OnPremisesTagSet                 *DeploymentGroupOnPremisesTagSet                 `pulumi:"onPremisesTagSet"`
	ServiceRoleArn                   string                                           `pulumi:"serviceRoleArn"`
	TriggerConfigurations            []DeploymentGroupTriggerConfig                   `pulumi:"triggerConfigurations"`
}

// The set of arguments for constructing a DeploymentGroup resource.
type DeploymentGroupArgs struct {
	AlarmConfiguration               DeploymentGroupAlarmConfigurationPtrInput
	ApplicationName                  pulumi.StringInput
	AutoRollbackConfiguration        DeploymentGroupAutoRollbackConfigurationPtrInput
	AutoScalingGroups                pulumi.StringArrayInput
	BlueGreenDeploymentConfiguration DeploymentGroupBlueGreenDeploymentConfigurationPtrInput
	Deployment                       DeploymentGroupDeploymentPtrInput
	DeploymentConfigName             pulumi.StringPtrInput
	DeploymentGroupName              pulumi.StringPtrInput
	DeploymentStyle                  DeploymentGroupDeploymentStylePtrInput
	ECSServices                      DeploymentGroupECSServiceArrayInput
	Ec2TagFilters                    DeploymentGroupEC2TagFilterArrayInput
	Ec2TagSet                        DeploymentGroupEC2TagSetPtrInput
	LoadBalancerInfo                 DeploymentGroupLoadBalancerInfoPtrInput
	OnPremisesInstanceTagFilters     DeploymentGroupTagFilterArrayInput
	OnPremisesTagSet                 DeploymentGroupOnPremisesTagSetPtrInput
	ServiceRoleArn                   pulumi.StringInput
	TriggerConfigurations            DeploymentGroupTriggerConfigArrayInput
}

func (DeploymentGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentGroupArgs)(nil)).Elem()
}

type DeploymentGroupInput interface {
	pulumi.Input

	ToDeploymentGroupOutput() DeploymentGroupOutput
	ToDeploymentGroupOutputWithContext(ctx context.Context) DeploymentGroupOutput
}

func (*DeploymentGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentGroup)(nil))
}

func (i *DeploymentGroup) ToDeploymentGroupOutput() DeploymentGroupOutput {
	return i.ToDeploymentGroupOutputWithContext(context.Background())
}

func (i *DeploymentGroup) ToDeploymentGroupOutputWithContext(ctx context.Context) DeploymentGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentGroupOutput)
}

type DeploymentGroupOutput struct{ *pulumi.OutputState }

func (DeploymentGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentGroup)(nil))
}

func (o DeploymentGroupOutput) ToDeploymentGroupOutput() DeploymentGroupOutput {
	return o
}

func (o DeploymentGroupOutput) ToDeploymentGroupOutputWithContext(ctx context.Context) DeploymentGroupOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DeploymentGroupInput)(nil)).Elem(), &DeploymentGroup{})
	pulumi.RegisterOutputType(DeploymentGroupOutput{})
}
