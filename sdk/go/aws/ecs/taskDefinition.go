// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ecs

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Schema describing various properties for ECS TaskDefinition
type TaskDefinition struct {
	pulumi.CustomResourceState

	ContainerDefinitions    TaskDefinitionContainerDefinitionArrayOutput  `pulumi:"containerDefinitions"`
	Cpu                     pulumi.StringPtrOutput                        `pulumi:"cpu"`
	EphemeralStorage        TaskDefinitionEphemeralStoragePtrOutput       `pulumi:"ephemeralStorage"`
	ExecutionRoleArn        pulumi.StringPtrOutput                        `pulumi:"executionRoleArn"`
	Family                  pulumi.StringPtrOutput                        `pulumi:"family"`
	InferenceAccelerators   TaskDefinitionInferenceAcceleratorArrayOutput `pulumi:"inferenceAccelerators"`
	IpcMode                 pulumi.StringPtrOutput                        `pulumi:"ipcMode"`
	Memory                  pulumi.StringPtrOutput                        `pulumi:"memory"`
	NetworkMode             pulumi.StringPtrOutput                        `pulumi:"networkMode"`
	PidMode                 pulumi.StringPtrOutput                        `pulumi:"pidMode"`
	PlacementConstraints    TaskDefinitionPlacementConstraintArrayOutput  `pulumi:"placementConstraints"`
	ProxyConfiguration      TaskDefinitionProxyConfigurationPtrOutput     `pulumi:"proxyConfiguration"`
	RequiresCompatibilities pulumi.StringArrayOutput                      `pulumi:"requiresCompatibilities"`
	RuntimePlatform         TaskDefinitionRuntimePlatformPtrOutput        `pulumi:"runtimePlatform"`
	Tags                    TaskDefinitionTagArrayOutput                  `pulumi:"tags"`
	// The Amazon Resource Name (ARN) of the Amazon ECS task definition
	TaskDefinitionArn pulumi.StringOutput             `pulumi:"taskDefinitionArn"`
	TaskRoleArn       pulumi.StringPtrOutput          `pulumi:"taskRoleArn"`
	Volumes           TaskDefinitionVolumeArrayOutput `pulumi:"volumes"`
}

// NewTaskDefinition registers a new resource with the given unique name, arguments, and options.
func NewTaskDefinition(ctx *pulumi.Context,
	name string, args *TaskDefinitionArgs, opts ...pulumi.ResourceOption) (*TaskDefinition, error) {
	if args == nil {
		args = &TaskDefinitionArgs{}
	}

	var resource TaskDefinition
	err := ctx.RegisterResource("aws-native:ecs:TaskDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTaskDefinition gets an existing TaskDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTaskDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TaskDefinitionState, opts ...pulumi.ResourceOption) (*TaskDefinition, error) {
	var resource TaskDefinition
	err := ctx.ReadResource("aws-native:ecs:TaskDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TaskDefinition resources.
type taskDefinitionState struct {
}

type TaskDefinitionState struct {
}

func (TaskDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*taskDefinitionState)(nil)).Elem()
}

type taskDefinitionArgs struct {
	ContainerDefinitions    []TaskDefinitionContainerDefinition  `pulumi:"containerDefinitions"`
	Cpu                     *string                              `pulumi:"cpu"`
	EphemeralStorage        *TaskDefinitionEphemeralStorage      `pulumi:"ephemeralStorage"`
	ExecutionRoleArn        *string                              `pulumi:"executionRoleArn"`
	Family                  *string                              `pulumi:"family"`
	InferenceAccelerators   []TaskDefinitionInferenceAccelerator `pulumi:"inferenceAccelerators"`
	IpcMode                 *string                              `pulumi:"ipcMode"`
	Memory                  *string                              `pulumi:"memory"`
	NetworkMode             *string                              `pulumi:"networkMode"`
	PidMode                 *string                              `pulumi:"pidMode"`
	PlacementConstraints    []TaskDefinitionPlacementConstraint  `pulumi:"placementConstraints"`
	ProxyConfiguration      *TaskDefinitionProxyConfiguration    `pulumi:"proxyConfiguration"`
	RequiresCompatibilities []string                             `pulumi:"requiresCompatibilities"`
	RuntimePlatform         *TaskDefinitionRuntimePlatform       `pulumi:"runtimePlatform"`
	Tags                    []TaskDefinitionTag                  `pulumi:"tags"`
	TaskRoleArn             *string                              `pulumi:"taskRoleArn"`
	Volumes                 []TaskDefinitionVolume               `pulumi:"volumes"`
}

// The set of arguments for constructing a TaskDefinition resource.
type TaskDefinitionArgs struct {
	ContainerDefinitions    TaskDefinitionContainerDefinitionArrayInput
	Cpu                     pulumi.StringPtrInput
	EphemeralStorage        TaskDefinitionEphemeralStoragePtrInput
	ExecutionRoleArn        pulumi.StringPtrInput
	Family                  pulumi.StringPtrInput
	InferenceAccelerators   TaskDefinitionInferenceAcceleratorArrayInput
	IpcMode                 pulumi.StringPtrInput
	Memory                  pulumi.StringPtrInput
	NetworkMode             pulumi.StringPtrInput
	PidMode                 pulumi.StringPtrInput
	PlacementConstraints    TaskDefinitionPlacementConstraintArrayInput
	ProxyConfiguration      TaskDefinitionProxyConfigurationPtrInput
	RequiresCompatibilities pulumi.StringArrayInput
	RuntimePlatform         TaskDefinitionRuntimePlatformPtrInput
	Tags                    TaskDefinitionTagArrayInput
	TaskRoleArn             pulumi.StringPtrInput
	Volumes                 TaskDefinitionVolumeArrayInput
}

func (TaskDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*taskDefinitionArgs)(nil)).Elem()
}

type TaskDefinitionInput interface {
	pulumi.Input

	ToTaskDefinitionOutput() TaskDefinitionOutput
	ToTaskDefinitionOutputWithContext(ctx context.Context) TaskDefinitionOutput
}

func (*TaskDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*TaskDefinition)(nil))
}

func (i *TaskDefinition) ToTaskDefinitionOutput() TaskDefinitionOutput {
	return i.ToTaskDefinitionOutputWithContext(context.Background())
}

func (i *TaskDefinition) ToTaskDefinitionOutputWithContext(ctx context.Context) TaskDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TaskDefinitionOutput)
}

type TaskDefinitionOutput struct{ *pulumi.OutputState }

func (TaskDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TaskDefinition)(nil))
}

func (o TaskDefinitionOutput) ToTaskDefinitionOutput() TaskDefinitionOutput {
	return o
}

func (o TaskDefinitionOutput) ToTaskDefinitionOutputWithContext(ctx context.Context) TaskDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TaskDefinitionInput)(nil)).Elem(), &TaskDefinition{})
	pulumi.RegisterOutputType(TaskDefinitionOutput{})
}
