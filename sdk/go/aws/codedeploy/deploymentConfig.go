// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codedeploy

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::CodeDeploy::DeploymentConfig
//
// Deprecated: DeploymentConfig is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type DeploymentConfig struct {
	pulumi.CustomResourceState

	ComputePlatform      pulumi.StringPtrOutput                        `pulumi:"computePlatform"`
	DeploymentConfigName pulumi.StringPtrOutput                        `pulumi:"deploymentConfigName"`
	MinimumHealthyHosts  DeploymentConfigMinimumHealthyHostsPtrOutput  `pulumi:"minimumHealthyHosts"`
	TrafficRoutingConfig DeploymentConfigTrafficRoutingConfigPtrOutput `pulumi:"trafficRoutingConfig"`
}

// NewDeploymentConfig registers a new resource with the given unique name, arguments, and options.
func NewDeploymentConfig(ctx *pulumi.Context,
	name string, args *DeploymentConfigArgs, opts ...pulumi.ResourceOption) (*DeploymentConfig, error) {
	if args == nil {
		args = &DeploymentConfigArgs{}
	}

	var resource DeploymentConfig
	err := ctx.RegisterResource("aws-native:codedeploy:DeploymentConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeploymentConfig gets an existing DeploymentConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeploymentConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeploymentConfigState, opts ...pulumi.ResourceOption) (*DeploymentConfig, error) {
	var resource DeploymentConfig
	err := ctx.ReadResource("aws-native:codedeploy:DeploymentConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeploymentConfig resources.
type deploymentConfigState struct {
}

type DeploymentConfigState struct {
}

func (DeploymentConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentConfigState)(nil)).Elem()
}

type deploymentConfigArgs struct {
	ComputePlatform      *string                               `pulumi:"computePlatform"`
	DeploymentConfigName *string                               `pulumi:"deploymentConfigName"`
	MinimumHealthyHosts  *DeploymentConfigMinimumHealthyHosts  `pulumi:"minimumHealthyHosts"`
	TrafficRoutingConfig *DeploymentConfigTrafficRoutingConfig `pulumi:"trafficRoutingConfig"`
}

// The set of arguments for constructing a DeploymentConfig resource.
type DeploymentConfigArgs struct {
	ComputePlatform      pulumi.StringPtrInput
	DeploymentConfigName pulumi.StringPtrInput
	MinimumHealthyHosts  DeploymentConfigMinimumHealthyHostsPtrInput
	TrafficRoutingConfig DeploymentConfigTrafficRoutingConfigPtrInput
}

func (DeploymentConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentConfigArgs)(nil)).Elem()
}

type DeploymentConfigInput interface {
	pulumi.Input

	ToDeploymentConfigOutput() DeploymentConfigOutput
	ToDeploymentConfigOutputWithContext(ctx context.Context) DeploymentConfigOutput
}

func (*DeploymentConfig) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentConfig)(nil))
}

func (i *DeploymentConfig) ToDeploymentConfigOutput() DeploymentConfigOutput {
	return i.ToDeploymentConfigOutputWithContext(context.Background())
}

func (i *DeploymentConfig) ToDeploymentConfigOutputWithContext(ctx context.Context) DeploymentConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentConfigOutput)
}

type DeploymentConfigOutput struct{ *pulumi.OutputState }

func (DeploymentConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentConfig)(nil))
}

func (o DeploymentConfigOutput) ToDeploymentConfigOutput() DeploymentConfigOutput {
	return o
}

func (o DeploymentConfigOutput) ToDeploymentConfigOutputWithContext(ctx context.Context) DeploymentConfigOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DeploymentConfigOutput{})
}
