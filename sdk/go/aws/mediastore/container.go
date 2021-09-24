// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mediastore

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::MediaStore::Container
//
// Deprecated: Container is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Container struct {
	pulumi.CustomResourceState

	AccessLoggingEnabled pulumi.BoolPtrOutput           `pulumi:"accessLoggingEnabled"`
	ContainerName        pulumi.StringOutput            `pulumi:"containerName"`
	CorsPolicy           ContainerCorsRuleArrayOutput   `pulumi:"corsPolicy"`
	Endpoint             pulumi.StringOutput            `pulumi:"endpoint"`
	LifecyclePolicy      pulumi.StringPtrOutput         `pulumi:"lifecyclePolicy"`
	MetricPolicy         ContainerMetricPolicyPtrOutput `pulumi:"metricPolicy"`
	Policy               pulumi.StringPtrOutput         `pulumi:"policy"`
	Tags                 ContainerTagArrayOutput        `pulumi:"tags"`
}

// NewContainer registers a new resource with the given unique name, arguments, and options.
func NewContainer(ctx *pulumi.Context,
	name string, args *ContainerArgs, opts ...pulumi.ResourceOption) (*Container, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ContainerName == nil {
		return nil, errors.New("invalid value for required argument 'ContainerName'")
	}
	var resource Container
	err := ctx.RegisterResource("aws-native:mediastore:Container", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainer gets an existing Container resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerState, opts ...pulumi.ResourceOption) (*Container, error) {
	var resource Container
	err := ctx.ReadResource("aws-native:mediastore:Container", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Container resources.
type containerState struct {
}

type ContainerState struct {
}

func (ContainerState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerState)(nil)).Elem()
}

type containerArgs struct {
	AccessLoggingEnabled *bool                  `pulumi:"accessLoggingEnabled"`
	ContainerName        string                 `pulumi:"containerName"`
	CorsPolicy           []ContainerCorsRule    `pulumi:"corsPolicy"`
	LifecyclePolicy      *string                `pulumi:"lifecyclePolicy"`
	MetricPolicy         *ContainerMetricPolicy `pulumi:"metricPolicy"`
	Policy               *string                `pulumi:"policy"`
	Tags                 []ContainerTag         `pulumi:"tags"`
}

// The set of arguments for constructing a Container resource.
type ContainerArgs struct {
	AccessLoggingEnabled pulumi.BoolPtrInput
	ContainerName        pulumi.StringInput
	CorsPolicy           ContainerCorsRuleArrayInput
	LifecyclePolicy      pulumi.StringPtrInput
	MetricPolicy         ContainerMetricPolicyPtrInput
	Policy               pulumi.StringPtrInput
	Tags                 ContainerTagArrayInput
}

func (ContainerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerArgs)(nil)).Elem()
}

type ContainerInput interface {
	pulumi.Input

	ToContainerOutput() ContainerOutput
	ToContainerOutputWithContext(ctx context.Context) ContainerOutput
}

func (*Container) ElementType() reflect.Type {
	return reflect.TypeOf((*Container)(nil))
}

func (i *Container) ToContainerOutput() ContainerOutput {
	return i.ToContainerOutputWithContext(context.Background())
}

func (i *Container) ToContainerOutputWithContext(ctx context.Context) ContainerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerOutput)
}

type ContainerOutput struct{ *pulumi.OutputState }

func (ContainerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Container)(nil))
}

func (o ContainerOutput) ToContainerOutput() ContainerOutput {
	return o
}

func (o ContainerOutput) ToContainerOutputWithContext(ctx context.Context) ContainerOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ContainerOutput{})
}
