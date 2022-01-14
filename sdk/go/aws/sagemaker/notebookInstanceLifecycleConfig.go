// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SageMaker::NotebookInstanceLifecycleConfig
//
// Deprecated: NotebookInstanceLifecycleConfig is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type NotebookInstanceLifecycleConfig struct {
	pulumi.CustomResourceState

	NotebookInstanceLifecycleConfigName pulumi.StringPtrOutput                                                  `pulumi:"notebookInstanceLifecycleConfigName"`
	OnCreate                            NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookArrayOutput `pulumi:"onCreate"`
	OnStart                             NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookArrayOutput `pulumi:"onStart"`
}

// NewNotebookInstanceLifecycleConfig registers a new resource with the given unique name, arguments, and options.
func NewNotebookInstanceLifecycleConfig(ctx *pulumi.Context,
	name string, args *NotebookInstanceLifecycleConfigArgs, opts ...pulumi.ResourceOption) (*NotebookInstanceLifecycleConfig, error) {
	if args == nil {
		args = &NotebookInstanceLifecycleConfigArgs{}
	}

	var resource NotebookInstanceLifecycleConfig
	err := ctx.RegisterResource("aws-native:sagemaker:NotebookInstanceLifecycleConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNotebookInstanceLifecycleConfig gets an existing NotebookInstanceLifecycleConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNotebookInstanceLifecycleConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NotebookInstanceLifecycleConfigState, opts ...pulumi.ResourceOption) (*NotebookInstanceLifecycleConfig, error) {
	var resource NotebookInstanceLifecycleConfig
	err := ctx.ReadResource("aws-native:sagemaker:NotebookInstanceLifecycleConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NotebookInstanceLifecycleConfig resources.
type notebookInstanceLifecycleConfigState struct {
}

type NotebookInstanceLifecycleConfigState struct {
}

func (NotebookInstanceLifecycleConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookInstanceLifecycleConfigState)(nil)).Elem()
}

type notebookInstanceLifecycleConfigArgs struct {
	NotebookInstanceLifecycleConfigName *string                                                        `pulumi:"notebookInstanceLifecycleConfigName"`
	OnCreate                            []NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook `pulumi:"onCreate"`
	OnStart                             []NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook `pulumi:"onStart"`
}

// The set of arguments for constructing a NotebookInstanceLifecycleConfig resource.
type NotebookInstanceLifecycleConfigArgs struct {
	NotebookInstanceLifecycleConfigName pulumi.StringPtrInput
	OnCreate                            NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookArrayInput
	OnStart                             NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookArrayInput
}

func (NotebookInstanceLifecycleConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookInstanceLifecycleConfigArgs)(nil)).Elem()
}

type NotebookInstanceLifecycleConfigInput interface {
	pulumi.Input

	ToNotebookInstanceLifecycleConfigOutput() NotebookInstanceLifecycleConfigOutput
	ToNotebookInstanceLifecycleConfigOutputWithContext(ctx context.Context) NotebookInstanceLifecycleConfigOutput
}

func (*NotebookInstanceLifecycleConfig) ElementType() reflect.Type {
	return reflect.TypeOf((*NotebookInstanceLifecycleConfig)(nil))
}

func (i *NotebookInstanceLifecycleConfig) ToNotebookInstanceLifecycleConfigOutput() NotebookInstanceLifecycleConfigOutput {
	return i.ToNotebookInstanceLifecycleConfigOutputWithContext(context.Background())
}

func (i *NotebookInstanceLifecycleConfig) ToNotebookInstanceLifecycleConfigOutputWithContext(ctx context.Context) NotebookInstanceLifecycleConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotebookInstanceLifecycleConfigOutput)
}

type NotebookInstanceLifecycleConfigOutput struct{ *pulumi.OutputState }

func (NotebookInstanceLifecycleConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NotebookInstanceLifecycleConfig)(nil))
}

func (o NotebookInstanceLifecycleConfigOutput) ToNotebookInstanceLifecycleConfigOutput() NotebookInstanceLifecycleConfigOutput {
	return o
}

func (o NotebookInstanceLifecycleConfigOutput) ToNotebookInstanceLifecycleConfigOutputWithContext(ctx context.Context) NotebookInstanceLifecycleConfigOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NotebookInstanceLifecycleConfigInput)(nil)).Elem(), &NotebookInstanceLifecycleConfig{})
	pulumi.RegisterOutputType(NotebookInstanceLifecycleConfigOutput{})
}
