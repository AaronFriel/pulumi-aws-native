// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SageMaker::ImageVersion
type ImageVersion struct {
	pulumi.CustomResourceState

	BaseImage       pulumi.StringOutput `pulumi:"baseImage"`
	ContainerImage  pulumi.StringOutput `pulumi:"containerImage"`
	ImageArn        pulumi.StringOutput `pulumi:"imageArn"`
	ImageName       pulumi.StringOutput `pulumi:"imageName"`
	ImageVersionArn pulumi.StringOutput `pulumi:"imageVersionArn"`
	Version         pulumi.IntOutput    `pulumi:"version"`
}

// NewImageVersion registers a new resource with the given unique name, arguments, and options.
func NewImageVersion(ctx *pulumi.Context,
	name string, args *ImageVersionArgs, opts ...pulumi.ResourceOption) (*ImageVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BaseImage == nil {
		return nil, errors.New("invalid value for required argument 'BaseImage'")
	}
	if args.ImageName == nil {
		return nil, errors.New("invalid value for required argument 'ImageName'")
	}
	var resource ImageVersion
	err := ctx.RegisterResource("aws-native:sagemaker:ImageVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetImageVersion gets an existing ImageVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetImageVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ImageVersionState, opts ...pulumi.ResourceOption) (*ImageVersion, error) {
	var resource ImageVersion
	err := ctx.ReadResource("aws-native:sagemaker:ImageVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ImageVersion resources.
type imageVersionState struct {
}

type ImageVersionState struct {
}

func (ImageVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*imageVersionState)(nil)).Elem()
}

type imageVersionArgs struct {
	BaseImage string `pulumi:"baseImage"`
	ImageName string `pulumi:"imageName"`
}

// The set of arguments for constructing a ImageVersion resource.
type ImageVersionArgs struct {
	BaseImage pulumi.StringInput
	ImageName pulumi.StringInput
}

func (ImageVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*imageVersionArgs)(nil)).Elem()
}

type ImageVersionInput interface {
	pulumi.Input

	ToImageVersionOutput() ImageVersionOutput
	ToImageVersionOutputWithContext(ctx context.Context) ImageVersionOutput
}

func (*ImageVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*ImageVersion)(nil))
}

func (i *ImageVersion) ToImageVersionOutput() ImageVersionOutput {
	return i.ToImageVersionOutputWithContext(context.Background())
}

func (i *ImageVersion) ToImageVersionOutputWithContext(ctx context.Context) ImageVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ImageVersionOutput)
}

type ImageVersionOutput struct{ *pulumi.OutputState }

func (ImageVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ImageVersion)(nil))
}

func (o ImageVersionOutput) ToImageVersionOutput() ImageVersionOutput {
	return o
}

func (o ImageVersionOutput) ToImageVersionOutputWithContext(ctx context.Context) ImageVersionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ImageVersionOutput{})
}
