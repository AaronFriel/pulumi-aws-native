// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SageMaker::Model
//
// Deprecated: Model is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Model struct {
	pulumi.CustomResourceState

	Containers               ModelContainerDefinitionArrayOutput    `pulumi:"containers"`
	EnableNetworkIsolation   pulumi.BoolPtrOutput                   `pulumi:"enableNetworkIsolation"`
	ExecutionRoleArn         pulumi.StringOutput                    `pulumi:"executionRoleArn"`
	InferenceExecutionConfig ModelInferenceExecutionConfigPtrOutput `pulumi:"inferenceExecutionConfig"`
	ModelName                pulumi.StringPtrOutput                 `pulumi:"modelName"`
	PrimaryContainer         ModelContainerDefinitionPtrOutput      `pulumi:"primaryContainer"`
	Tags                     ModelTagArrayOutput                    `pulumi:"tags"`
	VpcConfig                ModelVpcConfigPtrOutput                `pulumi:"vpcConfig"`
}

// NewModel registers a new resource with the given unique name, arguments, and options.
func NewModel(ctx *pulumi.Context,
	name string, args *ModelArgs, opts ...pulumi.ResourceOption) (*Model, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ExecutionRoleArn == nil {
		return nil, errors.New("invalid value for required argument 'ExecutionRoleArn'")
	}
	var resource Model
	err := ctx.RegisterResource("aws-native:sagemaker:Model", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModel gets an existing Model resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModelState, opts ...pulumi.ResourceOption) (*Model, error) {
	var resource Model
	err := ctx.ReadResource("aws-native:sagemaker:Model", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Model resources.
type modelState struct {
}

type ModelState struct {
}

func (ModelState) ElementType() reflect.Type {
	return reflect.TypeOf((*modelState)(nil)).Elem()
}

type modelArgs struct {
	Containers               []ModelContainerDefinition     `pulumi:"containers"`
	EnableNetworkIsolation   *bool                          `pulumi:"enableNetworkIsolation"`
	ExecutionRoleArn         string                         `pulumi:"executionRoleArn"`
	InferenceExecutionConfig *ModelInferenceExecutionConfig `pulumi:"inferenceExecutionConfig"`
	ModelName                *string                        `pulumi:"modelName"`
	PrimaryContainer         *ModelContainerDefinition      `pulumi:"primaryContainer"`
	Tags                     []ModelTag                     `pulumi:"tags"`
	VpcConfig                *ModelVpcConfig                `pulumi:"vpcConfig"`
}

// The set of arguments for constructing a Model resource.
type ModelArgs struct {
	Containers               ModelContainerDefinitionArrayInput
	EnableNetworkIsolation   pulumi.BoolPtrInput
	ExecutionRoleArn         pulumi.StringInput
	InferenceExecutionConfig ModelInferenceExecutionConfigPtrInput
	ModelName                pulumi.StringPtrInput
	PrimaryContainer         ModelContainerDefinitionPtrInput
	Tags                     ModelTagArrayInput
	VpcConfig                ModelVpcConfigPtrInput
}

func (ModelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modelArgs)(nil)).Elem()
}

type ModelInput interface {
	pulumi.Input

	ToModelOutput() ModelOutput
	ToModelOutputWithContext(ctx context.Context) ModelOutput
}

func (*Model) ElementType() reflect.Type {
	return reflect.TypeOf((*Model)(nil))
}

func (i *Model) ToModelOutput() ModelOutput {
	return i.ToModelOutputWithContext(context.Background())
}

func (i *Model) ToModelOutputWithContext(ctx context.Context) ModelOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModelOutput)
}

type ModelOutput struct{ *pulumi.OutputState }

func (ModelOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Model)(nil))
}

func (o ModelOutput) ToModelOutput() ModelOutput {
	return o
}

func (o ModelOutput) ToModelOutputWithContext(ctx context.Context) ModelOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ModelOutput{})
}
